open System.Text.Json
open System.Text.Json.Serialization

type Email = Email of string

type Body =
    | Raw of string
    | Html of string

type Request = {
    Email : Email
    Body : Body
}

let req = {
    Email = Email "1"
    Body = Raw "raw"
}

let options = JsonSerializerOptions()
options.Converters.Add(JsonFSharpConverter())

let json = JsonSerializer.Serialize(req, options)

printfn $"{json}"
