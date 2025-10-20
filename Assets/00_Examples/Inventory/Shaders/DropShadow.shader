Shader "Unlit/DropShadow"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Range ("Range", Float) = 1.0
        _Pow ("Pow", Float) = 1.0
        _Color ("Color", Color) = (0,0,0,1)
    }
    SubShader
    {
        Tags
        {
            "RenderType"="Transparent"
        }
        Blend SrcAlpha OneMinusSrcAlpha
        Offset -1, 1
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            float _Range;
            float _Pow;
            fixed4 _Color;

            v2f vert(appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o, o.vertex);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target
            {
                float grad = length(i.uv * 2 - 1);
                grad /= _Range;
                grad = clamp(grad, 0, 1);
                grad = 1 - grad;
                grad = clamp(pow(grad, _Pow), 0, 1);
                fixed4 col = _Color;
                UNITY_APPLY_FOG(i.fogCoord, col);
                return fixed4(col.rgb, grad);
            }
            ENDCG
        }
    }
}