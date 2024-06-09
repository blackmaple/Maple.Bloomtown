using Maple.Bloomtown.GameModel.Demo;
using Maple.GameContext;
using Maple.MonoGameAssistant.Common;
using Maple.MonoGameAssistant.GameDTO;
using Maple.MonoGameAssistant.Model;
using Maple.MonoGameAssistant.WebApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace Maple.Bloomtown
{
    internal sealed class BloomtownWebApiService()
        : GameWebApi<BloomtownWebApiService, BloomtownGameService, BloomtownGameContext>("Bloomtown A Different Story Demo")
    {

        [ModuleInitializer]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2255:不应在库中使用 “ModuleInitializer” 属性", Justification = "<挂起>")]
        public static void Initializer()
        {
            Maple.MonoGameAssistant.DllExportTmp.DllExport.LoadApis();
            Initializer(8000);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)], EntryPoint = nameof(DllMain))]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static bool DllMain(nint hModule, [MarshalAs(UnmanagedType.U4)] EnumReasonForCall ul_reason_for_call, nint lpReserved)
        {
            switch (ul_reason_for_call)
            {
                case EnumReasonForCall.DLL_PROCESS_ATTACH:
                    {
                        break;
                    }
                case EnumReasonForCall.DLL_THREAD_ATTACH:
                case EnumReasonForCall.DLL_THREAD_DETACH:
                case EnumReasonForCall.DLL_PROCESS_DETACH:
                    {
                        break;
                    }

            }
            return true;
        }

    }

}
