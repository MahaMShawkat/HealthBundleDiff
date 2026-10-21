
using HealthBundleDiff.Core.Models;

namespace HealthBundleDiff.Ai.Models
{
    public record ResourceChangeExplanation(string ResourceType, string? ResourceId, string Explanation, ChangeType? ChangeType = null);
}
