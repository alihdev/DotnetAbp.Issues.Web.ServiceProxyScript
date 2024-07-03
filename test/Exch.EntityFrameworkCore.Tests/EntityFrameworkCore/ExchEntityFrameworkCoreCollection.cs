using Xunit;

namespace Exch.EntityFrameworkCore;

[CollectionDefinition(ExchTestConsts.CollectionDefinitionName)]
public class ExchEntityFrameworkCoreCollection : ICollectionFixture<ExchEntityFrameworkCoreFixture>
{

}
