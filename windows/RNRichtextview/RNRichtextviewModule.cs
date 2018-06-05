using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Richtextview.RNRichtextview
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNRichtextviewModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNRichtextviewModule"/>.
        /// </summary>
        internal RNRichtextviewModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNRichtextview";
            }
        }
    }
}
