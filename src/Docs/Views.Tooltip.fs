﻿module Docs.Views.Tooltip

open Feliz
open Feliz.Bulma
open Feliz.Bulma.Tooltip
open Shared
open Docs.Domain

let overview =
    Html.div [
        Bulma.title.h1 [
            Html.text "Feliz.Bulma.Tooltip "
            Html.a [
                prop.href "https://www.nuget.org/packages/Feliz.Bulma.Tooltip/"
                prop.children [
                    Html.img [
                        prop.src "https://img.shields.io/nuget/v/Feliz.Bulma.Tooltip.svg?style=flat-square"
                    ]
                ]
            ]
        ]
        Bulma.subtitle.h3 [
            Html.a [ prop.href "https://wikiki.github.io/elements/tooltip/"; prop.text "Tooltip" ]
            Html.text " extension for Feliz.Bulma"
        ]
        Html.hr []
        Bulma.content [
            Html.p "This library extends Feliz.Bulma by adding Tooltip component"
            code """open Feliz.Bulma.Tooltip

Bulma.button.a [
    tooltip.text "This is tooltip"
    tooltip.hasTooltipWarning
    color.isWarning
    prop.text "Hover me for tooltip"
]"""

            Html.p "Code above will add tooltip to button:"
            Bulma.button.a [
                tooltip.text "This is tooltip"
                tooltip.hasTooltipWarning
                color.isWarning
                prop.text "Hover me for tooltip"
            ]

        ]
    ]

let installation = Shared.installationView "Feliz.Bulma.Tooltip" "bulma-tooltip" "bulma-tooltip"
