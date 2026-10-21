using System;
using System.Collections.Generic;
using System.Text;

namespace HealthBundleDiff.Core.Models
{
    public record ResourceKey(string ResourceType, string? Id);
}
