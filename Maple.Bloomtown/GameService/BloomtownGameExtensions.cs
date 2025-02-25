using Maple.MonoGameAssistant.WebApi;
using Maple.MonoGameAssistant.Windows.Service;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.Bloomtown
{
    internal sealed partial class BloomtownGameExtensions()
    {


        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvStdcall)/*, typeof(CallConvSuppressGCTransition)*/], EntryPoint = nameof(Maple))]
        [return: MarshalAs(UnmanagedType.I4)]
        public static int Maple()
        {
            RunWebApiService();
            return 1;

            static void RunWebApiService(int millisecondsDelay = 18 * 1000)
            {

                var webapp = WebApiServiceExtensions.AsRunWebApiService(p =>
                {
                    p.GameName = "Bloomtown A Different Story";
                    p.QQ = "0";
                    p.Http = true;
                    p.AutoOpenUrl = true;
                    p.Port = 49009;
                }, services =>
                {
                    services.UseGameContextService<BloomtownGameService>();
                });
                //延迟启动
                Thread.Sleep(millisecondsDelay);
                webapp.Run();


            }
        }



    }
}
