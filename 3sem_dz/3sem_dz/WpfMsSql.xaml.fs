namespace WCFhostByWpfFsharpOnly

open System
open System.ServiceModel
open System.ServiceModel.Description
open System.Windows.Controls
open System.IO
open System.Windows.Markup
open System.Reflection
open Utilities
open Microsoft.FSharp.Control
open System.Windows
open DataCommonFsharp


type  WpfMsSql()  as this = 
    inherit UserControl()
    // XAML - MUST be Embedded Resource
    let mySr = new StreamReader(Assembly.Load("_3sem_dz").GetManifestResourceStream("WpfMsSql.xaml"))
    do this.Content <- XamlReader.Load(mySr.BaseStream):?> UserControl 

    let mutable btnStart : Button  = this.Content?btnStart
    let mutable btnStop : Button  = this.Content?btnStop

    let mutable host : ServiceHost = null 
    let startServer() =
        let baseAddress = new Uri("http://localhost:8080/WindowsServiceSQL")   
        do host <- new ServiceHost(typeof<SqlEvent>,  [|baseAddress|])
        do host.Description.Behaviors.Add(new ServiceMetadataBehavior(HttpGetEnabled = true))
        do host.AddServiceEndpoint(typeof<ISqlEvent>, new WSHttpBinding(),  baseAddress) |> ignore
       
        try
           do host.Open()
           do btnStart.IsEnabled <- false
        with
           | _ -> MessageBox.Show("You Must Run Application as Administrator.") |> ignore
 
                     

    do btnStart.Click.Add(fun _ -> do startServer())   // See file SqlEvent.fs - setup connection string ...first ..
    do btnStop.Click.Add(fun _ -> if not (isNull host) && not btnStart.IsEnabled  then  do host.Close()  // host MUST be opened !
                                  do Environment.Exit(0))


