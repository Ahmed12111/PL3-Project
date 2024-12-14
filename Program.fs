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



 // addWord Function



 // updateWord Function



 // deleteWord Function



 // searchWord Function



// Creating GUI 


[<EntryPoint>]
let main argv =
    Application.Run(createDictionaryForm()) // Gui 
    0
