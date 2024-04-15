using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Inspirational.Story.Of.Mechanic.RNInspirationalStoryOfMechanic
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNInspirationalStoryOfMechanicModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNInspirationalStoryOfMechanicModule"/>.
        /// </summary>
        internal RNInspirationalStoryOfMechanicModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNInspirationalStoryOfMechanic";
            }
        }
    }
}
