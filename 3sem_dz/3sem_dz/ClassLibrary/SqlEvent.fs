namespace WCFhostByWpfFsharpOnly

open System
open System.ServiceModel
open System.Collections.Generic
open System.Runtime.Serialization
open System.Runtime.InteropServices 
open System.Data
open System.Text
open DataCommonFsharp


[<DataContract>]
type SqlData = {
                 [<DataMember>] mutable Sql : string
               }

[<ServiceContract>]
type ISqlEvent = 
    [<OperationContract(IsOneWay=false)>]
    abstract member SqlEvent : value : SqlData -> DataSet
    [<OperationContract>]
    abstract member ServiceOK : unit -> string

type SqlEvent() =
    interface ISqlEvent with
        member x.SqlEvent(md: SqlData) = let dc = new DataCommon()  // SET CONNECTION STRING below
                                         do dc.ConnectionString <- "Persist Security Info=False;Integrated Security=true; Initial Catalog=XXXXXX; Server=XXXXXX"
                                         let ds = dc.GetDataSet(new StringBuilder(md.Sql))
                                         ds
        member x.ServiceOK() = "OK" 








   