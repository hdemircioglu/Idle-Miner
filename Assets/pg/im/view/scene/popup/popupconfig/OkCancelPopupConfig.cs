﻿using System.Collections.Generic;
using pg.core.view;
using pg.im.view.popup.popupresult;

namespace pg.im.view.popup.popupconfig
{
    public class OkCancelPopupConfig : PopupConfig
    {
        public static IPopupConfig GetOkCancelPopupConfig(string title, string message)
        {
            // @todo - MS - Localization.
            return PopulatedConfigInstance(new OkCancelPopupConfig(), title, message, "Ok", "Cancel");
        }

        public override IPopupResult GetPopupResult()
        {
            return new OkCancelPopupResult();
        }
    }
}