using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Scripting;

public class InsertarMacro
{
    [Start]
    public void InsertPageMacroVoid()
    {
        string strFilename = @"C:\Nombre_pagina_macro.emp";

        ActionCallingContext oAcc = new ActionCallingContext();
        CommandLineInterpreter oCLI = new CommandLineInterpreter();

        oAcc.AddParameter("filename", strFilename);
        oCLI.Execute("XMInsertPageMacro", oAcc);
    }
}
