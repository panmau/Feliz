namespace Feliz.Styles

open Fable.Core

(*
y = done but needs testing ? and adding of documentation
x = already added
- = not doable

y gridAutoFlow
y gridAutoRows
    can't add all combinations for: "multiple track-size values"
    but I can add the ones that make sense
y gridAutoColumns
x gridColumnGap (supported by column gap)


x grid-template-columns
x grid-template-rows
x grid-template-areas
- grid-template
- grid
x grid-row-start
x grid-column-start
x grid-row-end
x grid-column-end
x grid-row
x grid-column
x grid-area
x row-gap
x column-gap
x gap

is this even possible:
repeat()
minmax()
fit-content()

*)

// TODO fix me? Am I needed?
[<Erase>]
type gridAutoFlow =
    static member inline row : IGridAutoFlow = unbox "row"
    static member inline column : IGridAutoFlow = unbox "column"
    static member inline dense : IGridAutoFlow = unbox "dense"
    static member inline rowDense : IGridAutoFlow = unbox "row dense"
    static member inline columnDense : IGridAutoFlow = unbox "column dense"

[<Erase>]
type gridAutoRows =
    static member inline minContent : IGridAutoRow = unbox "min-content"
    static member inline maxContent : IGridAutoRow = unbox "max-content"
    static member inline auto : IGridAutoRow = unbox "auto"

[<Erase>]
type gridColumn =
    static member inline span(value: string) : IGridSpan = unbox("span " + value)
    static member inline span(value: string, count: int) : IGridSpan = unbox("span " + value + " " + (unbox<string> count))
    static member inline span(value: int) : IGridSpan = unbox("span " + (unbox<string> value))

[<Erase>]
type gridRow =
    static member inline span(value: string) : IGridSpan = unbox("span " + value)
    static member inline span(value: string, count: int) : IGridSpan = unbox("span " + value + " " + (unbox<string> count))
    static member inline span(value: int) : IGridSpan = unbox("span " + (unbox<string> value))

[<Erase>]
type grid =
    static member inline namedLine(value: string) : IGridTemplateItem = unbox ("[" + value + "]")
    static member inline namedLines(value: string[]) : IGridTemplateItem = unbox ("[" + (String.concat " " value) + "]")
    static member inline namedLines(value: string list) : IGridTemplateItem = unbox ("[" + (String.concat " " value) + "]")
    static member inline templateWidth(value: ICssUnit) : IGridTemplateItem = unbox value
    static member inline templateWidth(value: int) : IGridTemplateItem = unbox ((unbox<string>value) + "px")
    static member inline templateWidth(value: float) : IGridTemplateItem = unbox ((unbox<string>value) + "px")