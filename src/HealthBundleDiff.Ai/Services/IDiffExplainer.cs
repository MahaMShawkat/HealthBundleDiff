using HealthBundleDiff.Ai.Models;
using HealthBundleDiff.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthBundleDiff.Ai.Services;

public interface IDiffExplainer
{
    Task<List<ResourceChangeExplanation>> DescribeResourceChanges(IReadOnlyList<ResourceChange> resourceChanges);
}