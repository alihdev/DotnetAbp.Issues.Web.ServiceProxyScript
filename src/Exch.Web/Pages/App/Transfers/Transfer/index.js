$(function () {

    $("#TransferFilter :input").on('input', function () {
        dataTable.ajax.reload();
    });

    //After abp v7.2 use dynamicForm 'column-size' instead of the following settings
    //$('#TransferCollapse div').addClass('col-sm-3').parent().addClass('row');

    var getFilter = function () {
        var input = {};
        $("#TransferFilter")
            .serializeArray()
            .forEach(function (data) {
                if (data.value != '') {
                    input[abp.utils.toCamelCase(data.name.replace(/TransferFilter./g, ''))] = data.value;
                }
            })
        return input;
    };

    var l = abp.localization.getResource('Exch');

    var service = exch.web.controllers.app.transfers.transfer;
    var createModal = new abp.ModalManager(abp.appPath + 'App/Transfers/Transfer/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'App/Transfers/Transfer/EditModal');

    var dataTable = $('#TransferTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,//disable default searchbox
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList,getFilter),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('Exch.Transfer.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Exch.Transfer.Delete'),
                                confirmMessage: function (data) {
                                    return l('TransferDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('TransferName'),
                data: "name"
            },
            {
                title: l('TransferSlug'),
                data: "slug"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewTransferButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
