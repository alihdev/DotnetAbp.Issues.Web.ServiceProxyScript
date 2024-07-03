using Exch.Samples;
using Xunit;

namespace Exch.EntityFrameworkCore.Domains;

[Collection(ExchTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ExchEntityFrameworkCoreTestModule>
{

}
