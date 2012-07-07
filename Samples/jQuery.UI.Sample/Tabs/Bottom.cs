// Bottom.cs
// Script#/samples/jQuery.UI/jQuery.UI.Sample/Tabs
// Copyright (c) Ivaylo Gochkov, 2012
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using jQueryApi;
using jQueryApi.UI.Widgets;

namespace Sample.Tabs {
    internal static class Bottom {
        static Bottom() {
            jQuery.OnDocumentReady(delegate() {
                jQuery.Select("#tabs7")
                      .Plugin<TabsObject>()
                      .Tabs();

                jQuery.Select(".tabs-bottom .ui-tabs-nav, .tabs-bottom .ui-tabs-nav > *")
                      .RemoveClass("ui-corner-all ui-corner-top")
                      .AddClass("ui-corner-bottom");
            });
        }
    }
}
