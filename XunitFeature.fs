module Features

open TickSpec
open Xunit

let source = AssemblyStepDefinitionsSource(System.Reflection.Assembly.GetExecutingAssembly())
let scenarios resourceName = source.ScenariosFromEmbeddedResource resourceName |> MemberData.ofScenarios

[<Theory; MemberData("scenarios", "TickSpecTest.Addition.feature")>]
let Addition (scenario : Scenario) = scenario.Action.Invoke()