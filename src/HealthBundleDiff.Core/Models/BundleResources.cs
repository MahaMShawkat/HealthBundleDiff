using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HealthBundleDiff.Core.Models
{
    public record BundleResources(
    IReadOnlyDictionary<ResourceKey, Resource> ResourcesWithId,
    IReadOnlyList<(ResourceKey Key, Resource Resource)> DuplicateResources,
    IReadOnlyList<Resource> ResourcesWithoutId);
}
