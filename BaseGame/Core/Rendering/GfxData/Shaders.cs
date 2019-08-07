using T3DNetFramework.Generated.Classes.Sim;
using T3DNetFramework.Generated.Functions;

namespace BaseGame.Core.Rendering.GfxData
{
   public class Shaders
   {
      public static ShaderData PFX_PassthruShader { get; set; }

      public static void Init() {
         PFX_PassthruShader = new ShaderData("PFX_PassthruShader") {
            DXVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/postFX/postFxV.hlsl",
            DXPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/postFX/passthruP.hlsl",
            OGLVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/postFX/gl/postFxV.glsl",
            OGLPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/postFX/gl/passthruP.glsl",

            SamplerNames = {[0] = "$inputTex"},

            PixVersion = 2.0f
         };
         PFX_PassthruShader.RegisterSingleton();


         //-----------------------------------------------------------------------------
         //  This file contains shader data necessary for various engine utility functions
         //-----------------------------------------------------------------------------
         new ShaderData("ParticlesShaderData") {
            DXVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/particlesV.hlsl",
            DXPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/particlesP.hlsl",

            OGLVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/gl/particlesV.glsl",
            OGLPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/gl/particlesP.glsl",

            SamplerNames = {
               [0] = "$diffuseMap",
               [1] = "$deferredTex",
               [2] = "$paraboloidLightMap",
            },

            PixVersion = 2.0f
         }.RegisterSingleton();

         new ShaderData("OffscreenParticleCompositeShaderData") {
            DXVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/particleCompositeV.hlsl",
            DXPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/particleCompositeP.hlsl",

            OGLVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/gl/particleCompositeV.glsl",
            OGLPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/gl/particleCompositeP.glsl",


            SamplerNames = {
               [0] = "$colorSource",
               [1] = "$edgeSource",
            },

            PixVersion = 2.0f
         }.RegisterSingleton();

//-----------------------------------------------------------------------------
// Planar Reflection
//-----------------------------------------------------------------------------
         new ShaderData("ReflectBump") {
            DXVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/planarReflectBumpV.hlsl",
            DXPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/planarReflectBumpP.hlsl",

            OGLVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/gl/planarReflectBumpV.glsl",
            OGLPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/gl/planarReflectBumpP.glsl",

            SamplerNames = {
               [0] = "$diffuseMap",
               [1] = "$refractMap",
               [2] = "$bumpMap",
            },

            PixVersion = 2.0f
         }.RegisterSingleton();

         new ShaderData("Reflect") {
            DXVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/planarReflectV.hlsl",
            DXPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/planarReflectP.hlsl",

            OGLVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/gl/planarReflectV.glsl",
            OGLPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/gl/planarReflectP.glsl",

            SamplerNames = {
               [0] = "$diffuseMap",
               [1] = "$refractMap",
            },

            PixVersion = 2.0f
         }.RegisterSingleton();

//-----------------------------------------------------------------------------
// fxFoliageReplicator
//-----------------------------------------------------------------------------
         new ShaderData("fxFoliageReplicatorShader") {
            DXVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/fxFoliageReplicatorV.hlsl",
            DXPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/fxFoliageReplicatorP.hlsl",

            OGLVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/gl/fxFoliageReplicatorV.glsl",
            OGLPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/gl/fxFoliageReplicatorP.glsl",

            SamplerNames = {
               [0] = "$diffuseMap",
               [1] = "$alphaMap",
            },

            PixVersion = 1.4f
         }.RegisterSingleton();

//-----------------------------------------------------------------------------
// Volumetric Fog
//-----------------------------------------------------------------------------
         new ShaderData("VolumetricFogShader") {
            DXVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/VolumetricFog/VFogV.hlsl",
            DXPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/VolumetricFog/VFogP.hlsl",

            OGLVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/VolumetricFog/gl/VFogV.glsl",
            OGLPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/VolumetricFog/gl/VFogP.glsl",

            SamplerNames = {
               [0] = "$deferredTex",
               [1] = "$depthBuffer",
               [2] = "$frontBuffer",
               [3] = "$density",
            },

            PixVersion = 3.0f
         }.RegisterSingleton();

         new ShaderData("VolumetricFogReflectionShader") {
            DXVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/VolumetricFog/VFogPreV.hlsl",
            DXPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/VolumetricFog/VFogRefl.hlsl",

            OGLVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/VolumetricFog/gl/VFogPreV.glsl",
            OGLPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/VolumetricFog/gl/VFogRefl.glsl",

            PixVersion = 3.0f
         }.RegisterSingleton();

//-----------------------------------------------------------------------------
// CubeMap
//-----------------------------------------------------------------------------
         new ShaderData("CubemapSaveShader") {
            DXVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "cubemapSaveV.hlsl",
            DXPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "cubemapSaveP.hlsl",

            OGLVertexShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/gl/cubemapSaveV.glsl",
            OGLPixelShaderFile = Global.GetConsoleString("Core::CommonShaderPath") + "/gl/cubemapSaveP.glsl",

            SamplerNames = {
               [0] = "$cubemapTex",
            },

            PixVersion = 3.0f
         }.RegisterSingleton();
      }
   }
}
