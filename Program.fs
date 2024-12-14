open System
open System.IO
open System.Text.Json
open System.Windows.Forms
open System.Drawing

type DictionaryEntry = { Word: string; Definition: string }
let dictionaryFilePath = "dictionary.json"

 // readJson Function


 // writeJson Function


 // initializeDictionaryFile Function


module Dictionary =

 // loadDictionary Function
    

 // saveDictionary Function
let saveDictionary (dict: Map<string, string>) =
        let entries = dict |> Map.toList |> List.map (fun (word, definition) -> { Word = word; Definition = definition })
        writeJson dictionaryFilePath entries


 // addWord Function
let addWord (dict: Map<string, string>) (word: string) (definition: string) : Map<string, string> =
        let wordKey = word.ToLowerInvariant()
        if dict.ContainsKey(wordKey) then dict
        else dict.Add(wordKey, definition)



 // updateWord Function



 // deleteWord Function



 // searchWord Function



// Creating GUI 


[<EntryPoint>]
let main argv =
    Application.Run(createDictionaryForm()) // Gui 
    0
