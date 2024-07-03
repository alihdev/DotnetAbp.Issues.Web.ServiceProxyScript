using Exch.Samples;
using Xunit;

namespace Exch.EntityFrameworkCore.Applications;

[Collection(ExchTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ExchEntityFrameworkCoreTestModule>
{

}
