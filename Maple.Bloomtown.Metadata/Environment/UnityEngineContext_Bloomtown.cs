using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Microsoft.Extensions.Logging;

namespace Maple.Bloomtown.Metadata.Environment
{
    public static class UnityEngineContext_Bloomtown
    {



        public static UnityEngineContext_MONO Create(this MonoRuntimeContext context, ILogger logger)
        {
            //UnityEngine.ImageConversion:EncodeToPNG+77 - 48 B8 2072CE2DFD7F0000 - mov rax,UnityPlayer.dll+217220 { ("@USWH?l$?H???") }
            UnityEngineContext_MONO.Func_ENCODE_TO_PNG = 0x217220;
            //UnityEngine.Graphics:Blit2+7f - 48 B8 8084B52DFD7F0000 - mov rax,UnityPlayer.dll+88480 { ("@USVWAUAVH?l$?H??8") }
            UnityEngineContext_MONO.Func_BLIT2 = 0x88480;
            //UnityEngine.Sprite:get_rect_Injected+86 - 48 B8 509DBE2DFD7F0000 - mov rax,UnityPlayer.dll+119D50 { (610044232) }
            UnityEngineContext_MONO.Func_READ_PIXELS_IMPL_INJECTED = 0x119D50;
            //UnityEngine.Sprite:GetTextureRect_Injected+86 - 48 B8 408FBE2DFD7F0000 - mov rax,UnityPlayer.dll+118F40 { (610044232) }
            UnityEngineContext_MONO.Func_GET_TEXTURE_RECT_INJECTED = 0x118F40;

            return new UnityEngineContext_MONO(context, logger);
        }


    }
}
