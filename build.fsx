#I @"packages/FsReveal/fsreveal/"
#I @"packages/FAKE/tools/"
#I @"packages/RazorEngine/lib/net45/"
#I @"packages/Suave/lib/"

#r "FakeLib.dll"
#r "suave.dll"

#load "fsreveal.fsx"

open FsReveal
open Fake
open System.IO

open Suave.Types
open Suave.Web
open Suave.Http
open Suave.Http.Applicatives
open Suave.Http.Embedded
open Suave.Http.Files

open System
open System.Net


let outDir = "output"
let fullPath = System.IO.Path.Combine(__SOURCE_DIRECTORY__, outDir)

printfn "fullPath is %A" fullPath

Target "Clean" (fun _ ->
    CleanDirs [outDir]
)

let generateFor (file:FileInfo) =
    let rec tryGenerate trials =
        try
            let outputFileName = file.Name.Replace(file.Extension,".html")
            match file.Extension with   
            | ".md" ->  FsReveal.GenerateOutputFromMarkdownFile outDir outputFileName file.FullName
            | ".fsx" -> FsReveal.GenerateOutputFromScriptFile outDir outputFileName file.FullName
            | _ -> ()
        with 
        | exn when trials > 0 -> tryGenerate (trials - 1)
        | exn -> tracefn "Could not generate slides for %s" file.FullName

    tryGenerate 3



let config = 
    { default_config with
       bindings = [ HttpBinding.Create(HTTP, "127.0.0.1", 8100)];
       home_folder = Some fullPath;
       compressed_files_folder = None;
       
    }

async {
    GET >>= browse
    |> web_server config
} |> Async.Start

Target "GenerateSlides" (fun _ ->
    !! "slides/*.md"
      ++ "slides/*.md"
    |> Seq.map fileInfo
    |> Seq.iter generateFor
)

Target "KeepRunning" (fun _ ->

    use watcher = new FileSystemWatcher(DirectoryInfo("slides").FullName,"*.*")
    watcher.EnableRaisingEvents <- true
    watcher.Changed.Add(fun e -> fileInfo e.FullPath |> generateFor)
    watcher.Created.Add(fun e -> fileInfo e.FullPath |> generateFor)
    watcher.Renamed.Add(fun e -> fileInfo e.FullPath |> generateFor)

    traceImportant "Waiting for slide edits. Press any key to stop."

    System.Console.ReadKey() |> ignore

    watcher.EnableRaisingEvents <- false
    watcher.Dispose()
)

"Clean"
  ==> "GenerateSlides"
  ==> "KeepRunning"

RunTargetOrDefault "KeepRunning"
