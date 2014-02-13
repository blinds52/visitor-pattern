﻿using System;
using Microsoft.VisualStudio.Modeling.Validation;
using NuPattern.Diagnostics;
using NuPattern.Library;
using NuPattern.Library.Automation;
using NuPattern.Runtime;

namespace VisitorPattern.Automation.Commands
{
    /// <summary>
    /// A custom command design-time validation rule for the <see cref="LoadStart"/> command.
    /// </summary>
    [CommandValidationRule(typeof(LoadStart))]
    [CLSCompliant(false)]
    public class LoadStartValidation : ICommandValidationRule
    {
        private static readonly ITracer tracer = Tracer.Get<LoadStartValidation>();

        /// <summary>
        /// Called to validate the design-time settings on the custom command
        /// </summary>
        /// <param name="context">Validation context to be assigned errors and warnings.</param>
        /// <param name="settingsElement">The settings element in the model being validated</param>
        /// <param name="settings">Settings for the command</param>
        public void Validate(ValidationContext context, IAutomationSettingsSchema settingsElement, ICommandSettings settings)
        {
            try
            {
                // TODO: Validate a setting on the command
                // Note that a propValue1 may still not have a value if it was configured with a ValueProvider.
                //var propValue1 = settings.GetOrCreatePropertyValue(Reflector<LoadStart>.GetPropertyName(s => s.AProperty), String.Empty);
                //if (String.IsNullOrEmpty(propValue1))
                //{
                //    context.LogError(String.Format(CultureInfo.CurrentCulture, 
                //        "{0} is configured with an invalid value for its 'AProperty'. This value must be valid.", settingsElement.Name), "1", settingsElement as ModelElement);
                //}

            }
            catch (Exception ex)
            {
                // Make error trace statement for the failure
                tracer.Error(
                    "Validation rule LoadStartValidation unexpectedly failed, error was: '{0}'", ex.Message);
                throw;
            }
        }
    }
}
