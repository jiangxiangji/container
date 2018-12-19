﻿using System.Collections.Generic;
using Unity.Builder;

namespace Unity.Policy
{
    /// <summary>
    /// A policy that returns a sequence
    /// of fields that should be injected for the given type.
    /// </summary>
    public interface IFieldSelectorPolicy
    {
        /// <summary>
        /// Returns sequence of fields on the given type that
        /// should be set as part of building that object.
        /// </summary>
        /// <param name="context">Current build context.</param>
        /// <returns>Sequence of <see cref="System.Reflection.FieldInfo"/> objects
        /// that contain the properties to set.</returns>
        IEnumerable<object> SelectFields(ref BuilderContext context);
    }
}
