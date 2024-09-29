using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MonoCollectorDataV2;
using Maple.MonoGameAssistant.UnityCore.UnityEngine;
using Microsoft.Extensions.Logging;

namespace Maple.Bloomtown
{
    internal sealed partial class UnityEngineContext_Bloomtown : UnityEngineContext
    {
        public UnityEngineContext_Bloomtown(MonoRuntimeContext runtimeContext, ILogger logger) : base(runtimeContext, EnumMonoCollectorTypeVersion.MONO, logger, "202409140230")
        {
            //用MONO 编译的GAME 获取到UnityPlayer.dll 函数地址偏移不一样 需要根据每个游戏修改
            this.NativeMethodSetting.LoadNativeMethod_MONO(new UnityNativeMethodOffset()
            {
                //UnityEngine.ImageConversion:EncodeToPNG+77 - 48 B8 2072CE2DFD7F0000 - mov rax,UnityPlayer.dll+217220 { ("@USWH?l$?H???") }
                Func_ENCODE_TO_PNG = 0x217220,

                //UnityEngine.Graphics:Blit2+7f - 48 B8 8084B52DFD7F0000 - mov rax,UnityPlayer.dll+88480 { ("@USVWAUAVH?l$?H??8") }
                Func_BLIT2 = 0x88480,

                //UnityEngine.Sprite:get_rect_Injected+86 - 48 B8 509DBE2DFD7F0000 - mov rax,UnityPlayer.dll+119D50 { (610044232) }
                Func_GET_RECT_INJECTED = 0x119D50,

                //UnityEngine.Sprite:GetTextureRect_Injected+86 - 48 B8 408FBE2DFD7F0000 - mov rax,UnityPlayer.dll+118F40 { (610044232) }
                Func_GET_TEXTURE_RECT_INJECTED = 0x118F40
            });
        }



        private void CopyToTexture2D3(Texture2D.Ptr_Texture2D pSrc, Texture2D.Ptr_Texture2D pDest, in Rect.Ref_Rect ref_Rect)
        {
            int wIDTH = pSrc.GET_WIDTH();
            int hEIGHT = pSrc.GET_HEIGHT();
            RenderTexture.Ptr_RenderTexture ptr_RenderTexture = Maple.MonoGameAssistant.UnityCore.UnityEngine.RenderTexture.Ptr_RenderTexture.GET_TEMPORARY_0A(wIDTH, hEIGHT, 0, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
            NativeMethodSetting.BLIT2((nint)pSrc, (nint)ptr_RenderTexture);
            nint aCTIVE = Maple.MonoGameAssistant.UnityCore.UnityEngine.RenderTexture.Ptr_RenderTexture.GET_ACTIVE();
            Maple.MonoGameAssistant.UnityCore.UnityEngine.RenderTexture.Ptr_RenderTexture.SET_ACTIVE((nint)ptr_RenderTexture);
            int width = (int)ref_Rect.m_Width;
            int height = (int)ref_Rect.m_Height;
            pDest.CTOR_08(width, height);
            pDest.READ_PIXELS_01(ref_Rect, 0, 0);
            pDest.APPLY_02();
            Maple.MonoGameAssistant.UnityCore.UnityEngine.RenderTexture.Ptr_RenderTexture.SET_ACTIVE(aCTIVE);
            Maple.MonoGameAssistant.UnityCore.UnityEngine.RenderTexture.Ptr_RenderTexture.RELEASE_TEMPORARY((nint)ptr_RenderTexture);
        }


        public PMonoArray<byte> ReadSprite2Png3(Sprite.Ptr_Sprite pSprite)
        {
            if (!pSprite.Valid())
            {
                return default;
            }

            Texture2D.Ptr_Texture2D tEXTURE = pSprite.GET_TEXTURE();
            if (!tEXTURE.Valid())
            {
                return default;
            }

            UnityPlayerNativeMethodSetting.GET_TEXTURE_RECT_INJECTED(pSprite, out var ret);
            Texture2D.Ptr_Texture2D pDest = Texture2D.New<Texture2D.Ptr_Texture2D>(execDefCtor: false);
            CopyToTexture2D3(tEXTURE, pDest, in ret);
            return NativeMethodSetting.EncodeToPng(pDest);
        }


    }
}
