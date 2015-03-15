
// Copyright (C) 2015 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Value of GL_CLIP_DISTANCE6 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int CLIP_DISTANCE6 = 0x3006;

		/// <summary>
		/// Value of GL_CLIP_DISTANCE7 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int CLIP_DISTANCE7 = 0x3007;

		/// <summary>
		/// Value of GL_MAJOR_VERSION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int MAJOR_VERSION = 0x821B;

		/// <summary>
		/// Value of GL_MINOR_VERSION symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int MINOR_VERSION = 0x821C;

		/// <summary>
		/// Value of GL_NUM_EXTENSIONS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int NUM_EXTENSIONS = 0x821D;

		/// <summary>
		/// Value of GL_CONTEXT_FLAGS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int CONTEXT_FLAGS = 0x821E;

		/// <summary>
		/// Value of GL_COMPRESSED_RED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int COMPRESSED_RED = 0x8225;

		/// <summary>
		/// Value of GL_COMPRESSED_RG symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int COMPRESSED_RG = 0x8226;

		/// <summary>
		/// Value of GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const uint CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001;

		/// <summary>
		/// Value of GL_RGBA32F symbol.
		/// </summary>
		[AliasOf("GL_RGBA32F_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int RGBA32F = 0x8814;

		/// <summary>
		/// Value of GL_RGB32F symbol.
		/// </summary>
		[AliasOf("GL_RGB32F_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_buffer_object_rgb32")]
		public const int RGB32F = 0x8815;

		/// <summary>
		/// Value of GL_RGBA16F symbol.
		/// </summary>
		[AliasOf("GL_RGBA16F_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int RGBA16F = 0x881A;

		/// <summary>
		/// Value of GL_RGB16F symbol.
		/// </summary>
		[AliasOf("GL_RGB16F_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int RGB16F = 0x881B;

		/// <summary>
		/// Value of GL_VERTEX_ATTRIB_ARRAY_INTEGER symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_INTEGER_EXT")]
		[AliasOf("GL_VERTEX_ATTRIB_ARRAY_INTEGER_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD;

		/// <summary>
		/// Value of GL_MAX_ARRAY_TEXTURE_LAYERS symbol.
		/// </summary>
		[AliasOf("GL_MAX_ARRAY_TEXTURE_LAYERS_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int MAX_ARRAY_TEXTURE_LAYERS = 0x88FF;

		/// <summary>
		/// Value of GL_MIN_PROGRAM_TEXEL_OFFSET symbol.
		/// </summary>
		[AliasOf("GL_MIN_PROGRAM_TEXEL_OFFSET_EXT")]
		[AliasOf("GL_MIN_PROGRAM_TEXEL_OFFSET_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int MIN_PROGRAM_TEXEL_OFFSET = 0x8904;

		/// <summary>
		/// Value of GL_MAX_PROGRAM_TEXEL_OFFSET symbol.
		/// </summary>
		[AliasOf("GL_MAX_PROGRAM_TEXEL_OFFSET_EXT")]
		[AliasOf("GL_MAX_PROGRAM_TEXEL_OFFSET_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int MAX_PROGRAM_TEXEL_OFFSET = 0x8905;

		/// <summary>
		/// Value of GL_CLAMP_READ_COLOR symbol.
		/// </summary>
		[AliasOf("GL_CLAMP_READ_COLOR_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int CLAMP_READ_COLOR = 0x891C;

		/// <summary>
		/// Value of GL_FIXED_ONLY symbol.
		/// </summary>
		[AliasOf("GL_FIXED_ONLY_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int FIXED_ONLY = 0x891D;

		/// <summary>
		/// Value of GL_MAX_VARYING_COMPONENTS symbol.
		/// </summary>
		/// <remarks>
		/// <para>
		/// This enumerant is equaivalent to MAX_VARYING_FLOATS.
		/// </para>
		/// </remarks>
		[AliasOf("GL_MAX_VARYING_COMPONENTS_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int MAX_VARYING_COMPONENTS = 0x8B4B;

		/// <summary>
		/// Value of GL_TEXTURE_1D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_1D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_1D_ARRAY = 0x8C18;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_1D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_PROXY_TEXTURE_1D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int PROXY_TEXTURE_1D_ARRAY = 0x8C19;

		/// <summary>
		/// Value of GL_TEXTURE_2D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_2D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		public const int TEXTURE_2D_ARRAY = 0x8C1A;

		/// <summary>
		/// Value of GL_PROXY_TEXTURE_2D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_PROXY_TEXTURE_2D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int PROXY_TEXTURE_2D_ARRAY = 0x8C1B;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_1D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_BINDING_1D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int TEXTURE_BINDING_1D_ARRAY = 0x8C1C;

		/// <summary>
		/// Value of GL_TEXTURE_BINDING_2D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_BINDING_2D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access")]
		public const int TEXTURE_BINDING_2D_ARRAY = 0x8C1D;

		/// <summary>
		/// Value of GL_R11F_G11F_B10F symbol.
		/// </summary>
		[AliasOf("GL_R11F_G11F_B10F_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int R11F_G11F_B10F = 0x8C3A;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_10F_11F_11F_REV symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_10F_11F_11F_REV_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_vertex_type_10f_11f_11f_rev")]
		public const int UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B;

		/// <summary>
		/// Value of GL_RGB9_E5 symbol.
		/// </summary>
		[AliasOf("GL_RGB9_E5_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int RGB9_E5 = 0x8C3D;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_5_9_9_9_REV symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_5_9_9_9_REV_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int UNSIGNED_INT_5_9_9_9_REV = 0x8C3E;

		/// <summary>
		/// Value of GL_TEXTURE_SHARED_SIZE symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_SHARED_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int TEXTURE_SHARED_SIZE = 0x8C3F;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH symbol.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_MODE symbol.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_MODE_EXT")]
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_MODE_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F;

		/// <summary>
		/// Value of GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS symbol.
		/// </summary>
		[AliasOf("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_EXT")]
		[AliasOf("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_VARYINGS symbol.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_VARYINGS_EXT")]
		[AliasOf("GL_TRANSFORM_FEEDBACK_VARYINGS_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int TRANSFORM_FEEDBACK_VARYINGS = 0x8C83;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_START symbol.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_START_EXT")]
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_START_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int TRANSFORM_FEEDBACK_BUFFER_START = 0x8C84;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_SIZE symbol.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_EXT")]
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_SIZE_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int TRANSFORM_FEEDBACK_BUFFER_SIZE = 0x8C85;

		/// <summary>
		/// Value of GL_PRIMITIVES_GENERATED symbol.
		/// </summary>
		[AliasOf("GL_PRIMITIVES_GENERATED_EXT")]
		[AliasOf("GL_PRIMITIVES_GENERATED_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int PRIMITIVES_GENERATED = 0x8C87;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN symbol.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_EXT")]
		[AliasOf("GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN = 0x8C88;

		/// <summary>
		/// Value of GL_RASTERIZER_DISCARD symbol.
		/// </summary>
		[AliasOf("GL_RASTERIZER_DISCARD_EXT")]
		[AliasOf("GL_RASTERIZER_DISCARD_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int RASTERIZER_DISCARD = 0x8C89;

		/// <summary>
		/// Value of GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS symbol.
		/// </summary>
		[AliasOf("GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_EXT")]
		[AliasOf("GL_MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A;

		/// <summary>
		/// Value of GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS symbol.
		/// </summary>
		[AliasOf("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_EXT")]
		[AliasOf("GL_MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B;

		/// <summary>
		/// Value of GL_INTERLEAVED_ATTRIBS symbol.
		/// </summary>
		[AliasOf("GL_INTERLEAVED_ATTRIBS_EXT")]
		[AliasOf("GL_INTERLEAVED_ATTRIBS_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int INTERLEAVED_ATTRIBS = 0x8C8C;

		/// <summary>
		/// Value of GL_SEPARATE_ATTRIBS symbol.
		/// </summary>
		[AliasOf("GL_SEPARATE_ATTRIBS_EXT")]
		[AliasOf("GL_SEPARATE_ATTRIBS_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int SEPARATE_ATTRIBS = 0x8C8D;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_EXT")]
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_enhanced_layouts")]
		public const int TRANSFORM_FEEDBACK_BUFFER = 0x8C8E;

		/// <summary>
		/// Value of GL_TRANSFORM_FEEDBACK_BUFFER_BINDING symbol.
		/// </summary>
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_EXT")]
		[AliasOf("GL_TRANSFORM_FEEDBACK_BUFFER_BINDING_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F;

		/// <summary>
		/// Value of GL_RGBA32UI symbol.
		/// </summary>
		[AliasOf("GL_RGBA32UI_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int RGBA32UI = 0x8D70;

		/// <summary>
		/// Value of GL_RGB32UI symbol.
		/// </summary>
		[AliasOf("GL_RGB32UI_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_buffer_object_rgb32")]
		public const int RGB32UI = 0x8D71;

		/// <summary>
		/// Value of GL_RGBA16UI symbol.
		/// </summary>
		[AliasOf("GL_RGBA16UI_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int RGBA16UI = 0x8D76;

		/// <summary>
		/// Value of GL_RGB16UI symbol.
		/// </summary>
		[AliasOf("GL_RGB16UI_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int RGB16UI = 0x8D77;

		/// <summary>
		/// Value of GL_RGBA8UI symbol.
		/// </summary>
		[AliasOf("GL_RGBA8UI_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		public const int RGBA8UI = 0x8D7C;

		/// <summary>
		/// Value of GL_RGB8UI symbol.
		/// </summary>
		[AliasOf("GL_RGB8UI_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int RGB8UI = 0x8D7D;

		/// <summary>
		/// Value of GL_RGBA32I symbol.
		/// </summary>
		[AliasOf("GL_RGBA32I_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int RGBA32I = 0x8D82;

		/// <summary>
		/// Value of GL_RGB32I symbol.
		/// </summary>
		[AliasOf("GL_RGB32I_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_buffer_object_rgb32")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit")]
		public const int RGB32I = 0x8D83;

		/// <summary>
		/// Value of GL_RGBA16I symbol.
		/// </summary>
		[AliasOf("GL_RGBA16I_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int RGBA16I = 0x8D88;

		/// <summary>
		/// Value of GL_RGB16I symbol.
		/// </summary>
		[AliasOf("GL_RGB16I_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int RGB16I = 0x8D89;

		/// <summary>
		/// Value of GL_RGBA8I symbol.
		/// </summary>
		[AliasOf("GL_RGBA8I_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int RGBA8I = 0x8D8E;

		/// <summary>
		/// Value of GL_RGB8I symbol.
		/// </summary>
		[AliasOf("GL_RGB8I_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int RGB8I = 0x8D8F;

		/// <summary>
		/// Value of GL_RED_INTEGER symbol.
		/// </summary>
		[AliasOf("GL_RED_INTEGER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int RED_INTEGER = 0x8D94;

		/// <summary>
		/// Value of GL_GREEN_INTEGER symbol.
		/// </summary>
		[AliasOf("GL_GREEN_INTEGER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int GREEN_INTEGER = 0x8D95;

		/// <summary>
		/// Value of GL_BLUE_INTEGER symbol.
		/// </summary>
		[AliasOf("GL_BLUE_INTEGER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int BLUE_INTEGER = 0x8D96;

		/// <summary>
		/// Value of GL_RGB_INTEGER symbol.
		/// </summary>
		[AliasOf("GL_RGB_INTEGER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int RGB_INTEGER = 0x8D98;

		/// <summary>
		/// Value of GL_RGBA_INTEGER symbol.
		/// </summary>
		[AliasOf("GL_RGBA_INTEGER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int RGBA_INTEGER = 0x8D99;

		/// <summary>
		/// Value of GL_BGR_INTEGER symbol.
		/// </summary>
		[AliasOf("GL_BGR_INTEGER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int BGR_INTEGER = 0x8D9A;

		/// <summary>
		/// Value of GL_BGRA_INTEGER symbol.
		/// </summary>
		[AliasOf("GL_BGRA_INTEGER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int BGRA_INTEGER = 0x8D9B;

		/// <summary>
		/// Value of GL_SAMPLER_1D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_1D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int SAMPLER_1D_ARRAY = 0x8DC0;

		/// <summary>
		/// Value of GL_SAMPLER_2D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_2D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int SAMPLER_2D_ARRAY = 0x8DC1;

		/// <summary>
		/// Value of GL_SAMPLER_1D_ARRAY_SHADOW symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_1D_ARRAY_SHADOW_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int SAMPLER_1D_ARRAY_SHADOW = 0x8DC3;

		/// <summary>
		/// Value of GL_SAMPLER_2D_ARRAY_SHADOW symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_2D_ARRAY_SHADOW_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int SAMPLER_2D_ARRAY_SHADOW = 0x8DC4;

		/// <summary>
		/// Value of GL_SAMPLER_CUBE_SHADOW symbol.
		/// </summary>
		[AliasOf("GL_SAMPLER_CUBE_SHADOW_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int SAMPLER_CUBE_SHADOW = 0x8DC5;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_VEC2 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_VEC2_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int UNSIGNED_INT_VEC2 = 0x8DC6;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_VEC3 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_VEC3_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int UNSIGNED_INT_VEC3 = 0x8DC7;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_VEC4 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_VEC4_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int UNSIGNED_INT_VEC4 = 0x8DC8;

		/// <summary>
		/// Value of GL_INT_SAMPLER_1D symbol.
		/// </summary>
		[AliasOf("GL_INT_SAMPLER_1D_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int INT_SAMPLER_1D = 0x8DC9;

		/// <summary>
		/// Value of GL_INT_SAMPLER_2D symbol.
		/// </summary>
		[AliasOf("GL_INT_SAMPLER_2D_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int INT_SAMPLER_2D = 0x8DCA;

		/// <summary>
		/// Value of GL_INT_SAMPLER_3D symbol.
		/// </summary>
		[AliasOf("GL_INT_SAMPLER_3D_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int INT_SAMPLER_3D = 0x8DCB;

		/// <summary>
		/// Value of GL_INT_SAMPLER_CUBE symbol.
		/// </summary>
		[AliasOf("GL_INT_SAMPLER_CUBE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int INT_SAMPLER_CUBE = 0x8DCC;

		/// <summary>
		/// Value of GL_INT_SAMPLER_1D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_INT_SAMPLER_1D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int INT_SAMPLER_1D_ARRAY = 0x8DCE;

		/// <summary>
		/// Value of GL_INT_SAMPLER_2D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_INT_SAMPLER_2D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int INT_SAMPLER_2D_ARRAY = 0x8DCF;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_1D symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_SAMPLER_1D_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int UNSIGNED_INT_SAMPLER_1D = 0x8DD1;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_2D symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_SAMPLER_2D_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int UNSIGNED_INT_SAMPLER_2D = 0x8DD2;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_3D symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_SAMPLER_3D_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int UNSIGNED_INT_SAMPLER_3D = 0x8DD3;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_CUBE symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_SAMPLER_CUBE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_1D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_SAMPLER_1D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_SAMPLER_2D_ARRAY symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_SAMPLER_2D_ARRAY_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7;

		/// <summary>
		/// Value of GL_QUERY_WAIT symbol.
		/// </summary>
		[AliasOf("GL_QUERY_WAIT_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int QUERY_WAIT = 0x8E13;

		/// <summary>
		/// Value of GL_QUERY_NO_WAIT symbol.
		/// </summary>
		[AliasOf("GL_QUERY_NO_WAIT_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int QUERY_NO_WAIT = 0x8E14;

		/// <summary>
		/// Value of GL_QUERY_BY_REGION_WAIT symbol.
		/// </summary>
		[AliasOf("GL_QUERY_BY_REGION_WAIT_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int QUERY_BY_REGION_WAIT = 0x8E15;

		/// <summary>
		/// Value of GL_QUERY_BY_REGION_NO_WAIT symbol.
		/// </summary>
		[AliasOf("GL_QUERY_BY_REGION_NO_WAIT_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int QUERY_BY_REGION_NO_WAIT = 0x8E16;

		/// <summary>
		/// Value of GL_BUFFER_ACCESS_FLAGS symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int BUFFER_ACCESS_FLAGS = 0x911F;

		/// <summary>
		/// Value of GL_BUFFER_MAP_LENGTH symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int BUFFER_MAP_LENGTH = 0x9120;

		/// <summary>
		/// Value of GL_BUFFER_MAP_OFFSET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int BUFFER_MAP_OFFSET = 0x9121;

		/// <summary>
		/// Value of GL_DEPTH_COMPONENT32F symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_depth_buffer_float")]
		public const int DEPTH_COMPONENT32F = 0x8CAC;

		/// <summary>
		/// Value of GL_DEPTH32F_STENCIL8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_depth_buffer_float")]
		public const int DEPTH32F_STENCIL8 = 0x8CAD;

		/// <summary>
		/// Value of GL_FLOAT_32_UNSIGNED_INT_24_8_REV symbol.
		/// </summary>
		[AliasOf("GL_FLOAT_32_UNSIGNED_INT_24_8_REV_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_depth_buffer_float")]
		public const int FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD;

		/// <summary>
		/// Value of GL_INVALID_FRAMEBUFFER_OPERATION symbol.
		/// </summary>
		[AliasOf("GL_INVALID_FRAMEBUFFER_OPERATION_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int INVALID_FRAMEBUFFER_OPERATION = 0x0506;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING = 0x8210;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE = 0x8211;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_RED_SIZE = 0x8212;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_GREEN_SIZE = 0x8213;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_BLUE_SIZE = 0x8214;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE = 0x8215;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE = 0x8216;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE = 0x8217;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_DEFAULT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_DEFAULT = 0x8218;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_UNDEFINED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_UNDEFINED = 0x8219;

		/// <summary>
		/// Value of GL_DEPTH_STENCIL_ATTACHMENT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int DEPTH_STENCIL_ATTACHMENT = 0x821A;

		/// <summary>
		/// Value of GL_MAX_RENDERBUFFER_SIZE symbol.
		/// </summary>
		[AliasOf("GL_MAX_RENDERBUFFER_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int MAX_RENDERBUFFER_SIZE = 0x84E8;

		/// <summary>
		/// Value of GL_DEPTH_STENCIL symbol.
		/// </summary>
		[AliasOf("GL_DEPTH_STENCIL_EXT")]
		[AliasOf("GL_DEPTH_STENCIL_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int DEPTH_STENCIL = 0x84F9;

		/// <summary>
		/// Value of GL_UNSIGNED_INT_24_8 symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_INT_24_8_EXT")]
		[AliasOf("GL_UNSIGNED_INT_24_8_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int UNSIGNED_INT_24_8 = 0x84FA;

		/// <summary>
		/// Value of GL_DEPTH24_STENCIL8 symbol.
		/// </summary>
		[AliasOf("GL_DEPTH24_STENCIL8_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int DEPTH24_STENCIL8 = 0x88F0;

		/// <summary>
		/// Value of GL_TEXTURE_STENCIL_SIZE symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_STENCIL_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int TEXTURE_STENCIL_SIZE = 0x88F1;

		/// <summary>
		/// Value of GL_TEXTURE_RED_TYPE symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_RED_TYPE_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int TEXTURE_RED_TYPE = 0x8C10;

		/// <summary>
		/// Value of GL_TEXTURE_GREEN_TYPE symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_GREEN_TYPE_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int TEXTURE_GREEN_TYPE = 0x8C11;

		/// <summary>
		/// Value of GL_TEXTURE_BLUE_TYPE symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_BLUE_TYPE_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int TEXTURE_BLUE_TYPE = 0x8C12;

		/// <summary>
		/// Value of GL_TEXTURE_ALPHA_TYPE symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_ALPHA_TYPE_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int TEXTURE_ALPHA_TYPE = 0x8C13;

		/// <summary>
		/// Value of GL_TEXTURE_DEPTH_TYPE symbol.
		/// </summary>
		[AliasOf("GL_TEXTURE_DEPTH_TYPE_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		public const int TEXTURE_DEPTH_TYPE = 0x8C16;

		/// <summary>
		/// Value of GL_UNSIGNED_NORMALIZED symbol.
		/// </summary>
		[AliasOf("GL_UNSIGNED_NORMALIZED_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int UNSIGNED_NORMALIZED = 0x8C17;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_BINDING symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_BINDING_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_BINDING = 0x8CA6;

		/// <summary>
		/// Value of GL_DRAW_FRAMEBUFFER_BINDING symbol.
		/// </summary>
		[AliasOf("GL_DRAW_FRAMEBUFFER_BINDING_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int DRAW_FRAMEBUFFER_BINDING = 0x8CA6;

		/// <summary>
		/// Value of GL_RENDERBUFFER_BINDING symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_BINDING_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_BINDING = 0x8CA7;

		/// <summary>
		/// Value of GL_READ_FRAMEBUFFER symbol.
		/// </summary>
		[AliasOf("GL_READ_FRAMEBUFFER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int READ_FRAMEBUFFER = 0x8CA8;

		/// <summary>
		/// Value of GL_DRAW_FRAMEBUFFER symbol.
		/// </summary>
		[AliasOf("GL_DRAW_FRAMEBUFFER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int DRAW_FRAMEBUFFER = 0x8CA9;

		/// <summary>
		/// Value of GL_READ_FRAMEBUFFER_BINDING symbol.
		/// </summary>
		[AliasOf("GL_READ_FRAMEBUFFER_BINDING_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int READ_FRAMEBUFFER_BINDING = 0x8CAA;

		/// <summary>
		/// Value of GL_RENDERBUFFER_SAMPLES symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_SAMPLES_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_SAMPLES = 0x8CAB;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE = 0x8CD0;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_OBJECT_NAME = 0x8CD1;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL = 0x8CD2;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE = 0x8CD3;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		[RequiredByFeature("GL_ARB_geometry_shader4")]
		public const int FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER = 0x8CD4;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_COMPLETE symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_COMPLETE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_COMPLETE = 0x8CD5;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_UNSUPPORTED symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_UNSUPPORTED_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_UNSUPPORTED = 0x8CDD;

		/// <summary>
		/// Value of GL_MAX_COLOR_ATTACHMENTS symbol.
		/// </summary>
		[AliasOf("GL_MAX_COLOR_ATTACHMENTS_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int MAX_COLOR_ATTACHMENTS = 0x8CDF;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT0 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT0_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT0 = 0x8CE0;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT1 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT1_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT1 = 0x8CE1;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT2 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT2_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT2 = 0x8CE2;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT3 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT3_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT3 = 0x8CE3;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT4 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT4_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT4 = 0x8CE4;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT5 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT5_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT5 = 0x8CE5;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT6 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT6_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT6 = 0x8CE6;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT7 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT7_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT7 = 0x8CE7;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT8 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT8_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT8 = 0x8CE8;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT9 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT9_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT9 = 0x8CE9;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT10 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT10_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT10 = 0x8CEA;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT11 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT11_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT11 = 0x8CEB;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT12 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT12_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT12 = 0x8CEC;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT13 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT13_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT13 = 0x8CED;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT14 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT14_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT14 = 0x8CEE;

		/// <summary>
		/// Value of GL_COLOR_ATTACHMENT15 symbol.
		/// </summary>
		[AliasOf("GL_COLOR_ATTACHMENT15_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int COLOR_ATTACHMENT15 = 0x8CEF;

		/// <summary>
		/// Value of GL_DEPTH_ATTACHMENT symbol.
		/// </summary>
		[AliasOf("GL_DEPTH_ATTACHMENT_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int DEPTH_ATTACHMENT = 0x8D00;

		/// <summary>
		/// Value of GL_STENCIL_ATTACHMENT symbol.
		/// </summary>
		[AliasOf("GL_STENCIL_ATTACHMENT_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int STENCIL_ATTACHMENT = 0x8D20;

		/// <summary>
		/// Value of GL_FRAMEBUFFER symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER = 0x8D40;

		/// <summary>
		/// Value of GL_RENDERBUFFER symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		[RequiredByFeature("GL_ARB_internalformat_query2")]
		[RequiredByFeature("GL_NV_internalformat_sample_query")]
		public const int RENDERBUFFER = 0x8D41;

		/// <summary>
		/// Value of GL_RENDERBUFFER_WIDTH symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_WIDTH_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_WIDTH = 0x8D42;

		/// <summary>
		/// Value of GL_RENDERBUFFER_HEIGHT symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_HEIGHT_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_HEIGHT = 0x8D43;

		/// <summary>
		/// Value of GL_RENDERBUFFER_INTERNAL_FORMAT symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_INTERNAL_FORMAT_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_INTERNAL_FORMAT = 0x8D44;

		/// <summary>
		/// Value of GL_STENCIL_INDEX1 symbol.
		/// </summary>
		[AliasOf("GL_STENCIL_INDEX1_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int STENCIL_INDEX1 = 0x8D46;

		/// <summary>
		/// Value of GL_STENCIL_INDEX4 symbol.
		/// </summary>
		[AliasOf("GL_STENCIL_INDEX4_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int STENCIL_INDEX4 = 0x8D47;

		/// <summary>
		/// Value of GL_STENCIL_INDEX8 symbol.
		/// </summary>
		[AliasOf("GL_STENCIL_INDEX8_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		[RequiredByFeature("GL_ARB_texture_stencil8")]
		public const int STENCIL_INDEX8 = 0x8D48;

		/// <summary>
		/// Value of GL_STENCIL_INDEX16 symbol.
		/// </summary>
		[AliasOf("GL_STENCIL_INDEX16_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int STENCIL_INDEX16 = 0x8D49;

		/// <summary>
		/// Value of GL_RENDERBUFFER_RED_SIZE symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_RED_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_RED_SIZE = 0x8D50;

		/// <summary>
		/// Value of GL_RENDERBUFFER_GREEN_SIZE symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_GREEN_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_GREEN_SIZE = 0x8D51;

		/// <summary>
		/// Value of GL_RENDERBUFFER_BLUE_SIZE symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_BLUE_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_BLUE_SIZE = 0x8D52;

		/// <summary>
		/// Value of GL_RENDERBUFFER_ALPHA_SIZE symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_ALPHA_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_ALPHA_SIZE = 0x8D53;

		/// <summary>
		/// Value of GL_RENDERBUFFER_DEPTH_SIZE symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_DEPTH_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_DEPTH_SIZE = 0x8D54;

		/// <summary>
		/// Value of GL_RENDERBUFFER_STENCIL_SIZE symbol.
		/// </summary>
		[AliasOf("GL_RENDERBUFFER_STENCIL_SIZE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int RENDERBUFFER_STENCIL_SIZE = 0x8D55;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56;

		/// <summary>
		/// Value of GL_MAX_SAMPLES symbol.
		/// </summary>
		[AliasOf("GL_MAX_SAMPLES_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int MAX_SAMPLES = 0x8D57;

		/// <summary>
		/// Value of GL_INDEX symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public const int INDEX = 0x8222;

		/// <summary>
		/// Value of GL_TEXTURE_LUMINANCE_TYPE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_TEXTURE_LUMINANCE_TYPE_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_LUMINANCE_TYPE = 0x8C14;

		/// <summary>
		/// Value of GL_TEXTURE_INTENSITY_TYPE symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_TEXTURE_INTENSITY_TYPE_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int TEXTURE_INTENSITY_TYPE = 0x8C15;

		/// <summary>
		/// Value of GL_FRAMEBUFFER_SRGB symbol.
		/// </summary>
		[AliasOf("GL_FRAMEBUFFER_SRGB_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_sRGB")]
		public const int FRAMEBUFFER_SRGB = 0x8DB9;

		/// <summary>
		/// Value of GL_HALF_FLOAT symbol.
		/// </summary>
		[AliasOf("GL_HALF_FLOAT_ARB")]
		[AliasOf("GL_HALF_FLOAT_NV")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_half_float_vertex")]
		public const int HALF_FLOAT = 0x140B;

		/// <summary>
		/// Value of GL_MAP_READ_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage")]
		[RequiredByFeature("GL_ARB_map_buffer_range")]
		public const int MAP_READ_BIT = 0x0001;

		/// <summary>
		/// Value of GL_MAP_WRITE_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage")]
		[RequiredByFeature("GL_ARB_map_buffer_range")]
		public const int MAP_WRITE_BIT = 0x0002;

		/// <summary>
		/// Value of GL_MAP_INVALIDATE_RANGE_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_map_buffer_range")]
		public const int MAP_INVALIDATE_RANGE_BIT = 0x0004;

		/// <summary>
		/// Value of GL_MAP_INVALIDATE_BUFFER_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_map_buffer_range")]
		public const int MAP_INVALIDATE_BUFFER_BIT = 0x0008;

		/// <summary>
		/// Value of GL_MAP_FLUSH_EXPLICIT_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_map_buffer_range")]
		public const int MAP_FLUSH_EXPLICIT_BIT = 0x0010;

		/// <summary>
		/// Value of GL_MAP_UNSYNCHRONIZED_BIT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_map_buffer_range")]
		public const int MAP_UNSYNCHRONIZED_BIT = 0x0020;

		/// <summary>
		/// Value of GL_COMPRESSED_RED_RGTC1 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_RED_RGTC1_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_compression_rgtc")]
		public const int COMPRESSED_RED_RGTC1 = 0x8DBB;

		/// <summary>
		/// Value of GL_COMPRESSED_SIGNED_RED_RGTC1 symbol.
		/// </summary>
		[AliasOf("GL_COMPRESSED_SIGNED_RED_RGTC1_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_compression_rgtc")]
		public const int COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC;

		/// <summary>
		/// Value of GL_COMPRESSED_RG_RGTC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_compression_rgtc")]
		public const int COMPRESSED_RG_RGTC2 = 0x8DBD;

		/// <summary>
		/// Value of GL_COMPRESSED_SIGNED_RG_RGTC2 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_compression_rgtc")]
		public const int COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE;

		/// <summary>
		/// Value of GL_RG symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG = 0x8227;

		/// <summary>
		/// Value of GL_RG_INTEGER symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG_INTEGER = 0x8228;

		/// <summary>
		/// Value of GL_R8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R8 = 0x8229;

		/// <summary>
		/// Value of GL_R16 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R16 = 0x822A;

		/// <summary>
		/// Value of GL_RG8 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG8 = 0x822B;

		/// <summary>
		/// Value of GL_RG16 symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG16 = 0x822C;

		/// <summary>
		/// Value of GL_R16F symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R16F = 0x822D;

		/// <summary>
		/// Value of GL_R32F symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R32F = 0x822E;

		/// <summary>
		/// Value of GL_RG16F symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG16F = 0x822F;

		/// <summary>
		/// Value of GL_RG32F symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG32F = 0x8230;

		/// <summary>
		/// Value of GL_R8I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R8I = 0x8231;

		/// <summary>
		/// Value of GL_R8UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R8UI = 0x8232;

		/// <summary>
		/// Value of GL_R16I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R16I = 0x8233;

		/// <summary>
		/// Value of GL_R16UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R16UI = 0x8234;

		/// <summary>
		/// Value of GL_R32I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R32I = 0x8235;

		/// <summary>
		/// Value of GL_R32UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int R32UI = 0x8236;

		/// <summary>
		/// Value of GL_RG8I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG8I = 0x8237;

		/// <summary>
		/// Value of GL_RG8UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG8UI = 0x8238;

		/// <summary>
		/// Value of GL_RG16I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG16I = 0x8239;

		/// <summary>
		/// Value of GL_RG16UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG16UI = 0x823A;

		/// <summary>
		/// Value of GL_RG32I symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG32I = 0x823B;

		/// <summary>
		/// Value of GL_RG32UI symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg")]
		public const int RG32UI = 0x823C;

		/// <summary>
		/// Value of GL_VERTEX_ARRAY_BINDING symbol.
		/// </summary>
		[AliasOf("GL_VERTEX_ARRAY_BINDING_APPLE")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_vertex_array_object")]
		public const int VERTEX_ARRAY_BINDING = 0x85B5;

		/// <summary>
		/// Value of GL_CLAMP_VERTEX_COLOR symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_CLAMP_VERTEX_COLOR_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLAMP_VERTEX_COLOR = 0x891A;

		/// <summary>
		/// Value of GL_CLAMP_FRAGMENT_COLOR symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_CLAMP_FRAGMENT_COLOR_ARB")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int CLAMP_FRAGMENT_COLOR = 0x891B;

		/// <summary>
		/// Value of GL_ALPHA_INTEGER symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_ALPHA_INTEGER_EXT")]
		[RequiredByFeature("GL_VERSION_3_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
#if DEBUG && !OPENGL_NET_COMPATIBILITY_PROFILE
		[Obsolete("Deprecated/removed by OpenGL 3.2.")]
#endif
		public const int ALPHA_INTEGER = 0x8D97;

		/// <summary>
		/// enable and disable writing of frame buffer color components
		/// </summary>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="r">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="g">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="b">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="a">
		/// A <see cref="T:bool"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void ColorMask(UInt32 index, bool r, bool g, bool b, bool a)
		{
			Debug.Assert(Delegates.pglColorMaski != null, "pglColorMaski not implemented");
			Delegates.pglColorMaski(index, r, g, b, a);
			CallLog("glColorMaski({0}, {1}, {2}, {3}, {4})", index, r, g, b, a);
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are 
		/// accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void Get(int target, UInt32 index, bool[] data)
		{
			unsafe {
				fixed (bool* p_data = data)
				{
					Debug.Assert(Delegates.pglGetBooleani_v != null, "pglGetBooleani_v not implemented");
					Delegates.pglGetBooleani_v(target, index, p_data);
					CallLog("glGetBooleani_v({0}, {1}, {2})", target, index, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are 
		/// accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void Get(int target, UInt32 index, out bool data)
		{
			unsafe {
				fixed (bool* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetBooleani_v != null, "pglGetBooleani_v not implemented");
					Delegates.pglGetBooleani_v(target, index, p_data);
					CallLog("glGetBooleani_v({0}, {1}, {2})", target, index, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are 
		/// accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void Get(int target, UInt32 index, Int32[] data)
		{
			unsafe {
				fixed (Int32* p_data = data)
				{
					Debug.Assert(Delegates.pglGetIntegeri_v != null, "pglGetIntegeri_v not implemented");
					Delegates.pglGetIntegeri_v(target, index, p_data);
					CallLog("glGetIntegeri_v({0}, {1}, {2})", target, index, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="target">
		/// Specifies the parameter value to be returned for indexed versions of glGet. The symbolic constants in the list below are 
		/// accepted.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the particular element being queried.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void Get(int target, UInt32 index, out Int32 data)
		{
			unsafe {
				fixed (Int32* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetIntegeri_v != null, "pglGetIntegeri_v not implemented");
					Delegates.pglGetIntegeri_v(target, index, p_data);
					CallLog("glGetIntegeri_v({0}, {1}, {2})", target, index, data);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glEnablei.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void Enable(int target, UInt32 index)
		{
			Debug.Assert(Delegates.pglEnablei != null, "pglEnablei not implemented");
			Delegates.pglEnablei(target, index);
			CallLog("glEnablei({0}, {1})", target, index);
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glDisablei.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void Disable(int target, UInt32 index)
		{
			Debug.Assert(Delegates.pglDisablei != null, "pglDisablei not implemented");
			Delegates.pglDisablei(target, index);
			CallLog("glDisablei({0}, {1})", target, index);
			DebugCheckErrors();
		}

		/// <summary>
		/// test whether a capability is enabled
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="index">
		/// Specifies the index of the capability.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static bool IsEnabledi(int target, UInt32 index)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsEnabledi != null, "pglIsEnabledi not implemented");
			retValue = Delegates.pglIsEnabledi(target, index);
			CallLog("glIsEnabledi({0}, {1}) = {2}", target, index, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// start transform feedback operation
		/// </summary>
		/// <param name="primitiveMode">
		/// Specify the output type of the primitives that will be recorded into the buffer objects that are bound for transform 
		/// feedback.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void BeginTransformFeedback(int primitiveMode)
		{
			Debug.Assert(Delegates.pglBeginTransformFeedback != null, "pglBeginTransformFeedback not implemented");
			Delegates.pglBeginTransformFeedback(primitiveMode);
			CallLog("glBeginTransformFeedback({0})", primitiveMode);
			DebugCheckErrors();
		}

		/// <summary>
		/// start transform feedback operation
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void EndTransformFeedback()
		{
			Debug.Assert(Delegates.pglEndTransformFeedback != null, "pglEndTransformFeedback not implemented");
			Delegates.pglEndTransformFeedback();
			CallLog("glEndTransformFeedback()");
			DebugCheckErrors();
		}

		/// <summary>
		/// bind a range within a buffer object to an indexed buffer target
		/// </summary>
		/// <param name="target">
		/// Specify the target of the bind operation. target must be one of GL_ATOMIC_COUNTER_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, 
		/// GL_UNIFORM_BUFFER, or GL_SHADER_STORAGE_BUFFER.
		/// </param>
		/// <param name="index">
		/// Specify the index of the binding point within the array specified by target.
		/// </param>
		/// <param name="buffer">
		/// The name of a buffer object to bind to the specified binding point.
		/// </param>
		/// <param name="offset">
		/// The starting offset in basic machine units into the buffer object buffer.
		/// </param>
		/// <param name="size">
		/// The amount of data in machine units that can be read from the buffer object while used as an indexed target.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void BindBufferRange(int target, UInt32 index, UInt32 buffer, IntPtr offset, UInt32 size)
		{
			Debug.Assert(Delegates.pglBindBufferRange != null, "pglBindBufferRange not implemented");
			Delegates.pglBindBufferRange(target, index, buffer, offset, size);
			CallLog("glBindBufferRange({0}, {1}, {2}, {3}, {4})", target, index, buffer, offset, size);
			DebugCheckErrors();
		}

		/// <summary>
		/// bind a buffer object to an indexed buffer target
		/// </summary>
		/// <param name="target">
		/// Specify the target of the bind operation. target must be one of GL_ATOMIC_COUNTER_BUFFER, GL_TRANSFORM_FEEDBACK_BUFFER, 
		/// GL_UNIFORM_BUFFER or GL_SHADER_STORAGE_BUFFER.
		/// </param>
		/// <param name="index">
		/// Specify the index of the binding point within the array specified by target.
		/// </param>
		/// <param name="buffer">
		/// The name of a buffer object to bind to the specified binding point.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void BindBufferBase(int target, UInt32 index, UInt32 buffer)
		{
			Debug.Assert(Delegates.pglBindBufferBase != null, "pglBindBufferBase not implemented");
			Delegates.pglBindBufferBase(target, index, buffer);
			CallLog("glBindBufferBase({0}, {1}, {2})", target, index, buffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// specify values to record in transform feedback buffers
		/// </summary>
		/// <param name="program">
		/// The name of the target program object.
		/// </param>
		/// <param name="count">
		/// The number of varying variables used for transform feedback.
		/// </param>
		/// <param name="varyings">
		/// An array of count zero-terminated strings specifying the names of the varying variables to use for transform feedback.
		/// </param>
		/// <param name="bufferMode">
		/// Identifies the mode used to capture the varying variables when transform feedback is active. bufferMode must be 
		/// GL_INTERLEAVED_ATTRIBS or GL_SEPARATE_ATTRIBS.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void TransformFeedbackVarying(UInt32 program, String[] varyings, int bufferMode)
		{
			Debug.Assert(Delegates.pglTransformFeedbackVaryings != null, "pglTransformFeedbackVaryings not implemented");
			Delegates.pglTransformFeedbackVaryings(program, (Int32)varyings.Length, varyings, bufferMode);
			CallLog("glTransformFeedbackVaryings({0}, {1}, {2}, {3})", program, varyings.Length, varyings, bufferMode);
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve information about varying variables selected for transform feedback
		/// </summary>
		/// <param name="program">
		/// The name of the target program object.
		/// </param>
		/// <param name="index">
		/// The index of the varying variable whose information to retrieve.
		/// </param>
		/// <param name="bufSize">
		/// The maximum number of characters, including the null terminator, that may be written into name.
		/// </param>
		/// <param name="length">
		/// The address of a variable which will receive the number of characters written into name, excluding the null-terminator. 
		/// If length is NULL no length is returned.
		/// </param>
		/// <param name="size">
		/// The address of a variable that will receive the size of the varying.
		/// </param>
		/// <param name="type">
		/// The address of a variable that will recieve the type of the varying.
		/// </param>
		/// <param name="name">
		/// The address of a buffer into which will be written the name of the varying.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void GetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, out Int32 length, out Int32 size, out int type, [Out] StringBuilder name)
		{
			unsafe {
				fixed (Int32* p_length = &length)
				fixed (Int32* p_size = &size)
				fixed (int* p_type = &type)
				{
					Debug.Assert(Delegates.pglGetTransformFeedbackVarying != null, "pglGetTransformFeedbackVarying not implemented");
					Delegates.pglGetTransformFeedbackVarying(program, index, bufSize, p_length, p_size, p_type, name);
					CallLog("glGetTransformFeedbackVarying({0}, {1}, {2}, {3}, {4}, {5}, {6})", program, index, bufSize, length, size, type, name);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// specify whether data read via glReadPixels should be clamped
		/// </summary>
		/// <param name="target">
		/// Target for color clamping. target must be GL_CLAMP_READ_COLOR.
		/// </param>
		/// <param name="clamp">
		/// Specifies whether to apply color clamping. clamp must be GL_TRUE or GL_FALSE.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void ClampColor(int target, int clamp)
		{
			Debug.Assert(Delegates.pglClampColor != null, "pglClampColor not implemented");
			Delegates.pglClampColor(target, clamp);
			CallLog("glClampColor({0}, {1})", target, clamp);
			DebugCheckErrors();
		}

		/// <summary>
		/// start conditional rendering
		/// </summary>
		/// <param name="id">
		/// Specifies the name of an occlusion query object whose results are used to determine if the rendering commands are 
		/// discarded.
		/// </param>
		/// <param name="mode">
		/// Specifies how glBeginConditionalRender interprets the results of the occlusion query.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void BeginConditionalRender(UInt32 id, int mode)
		{
			Debug.Assert(Delegates.pglBeginConditionalRender != null, "pglBeginConditionalRender not implemented");
			Delegates.pglBeginConditionalRender(id, mode);
			CallLog("glBeginConditionalRender({0}, {1})", id, mode);
			DebugCheckErrors();
		}

		/// <summary>
		/// start conditional rendering
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void EndConditionalRender()
		{
			Debug.Assert(Delegates.pglEndConditionalRender != null, "pglEndConditionalRender not implemented");
			Delegates.pglEndConditionalRender();
			CallLog("glEndConditionalRender()");
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of generic vertex attribute data
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="size">
		/// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic constant 
		/// GL_BGRA is accepted by glVertexAttribPointer. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each component in the array. The symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, 
		/// GL_UNSIGNED_SHORT, GL_INT, and GL_UNSIGNED_INT are accepted by glVertexAttribPointer and glVertexAttribIPointer. 
		/// Additionally GL_HALF_FLOAT, GL_FLOAT, GL_DOUBLE, GL_FIXED, GL_INT_2_10_10_10_REV, GL_UNSIGNED_INT_2_10_10_10_REV and 
		/// GL_UNSIGNED_INT_10F_11F_11F_REV are accepted by glVertexAttribPointer. GL_DOUBLE is also accepted by 
		/// glVertexAttribLPointer and is the only token accepted by the type parameter for that function. The initial value is 
		/// GL_FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes 
		/// are understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the 
		/// buffer currently bound to the GL_ARRAY_BUFFER target. The initial value is 0.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribIPointer(UInt32 index, Int32 size, int type, Int32 stride, IntPtr pointer)
		{
			Debug.Assert(Delegates.pglVertexAttribIPointer != null, "pglVertexAttribIPointer not implemented");
			Delegates.pglVertexAttribIPointer(index, size, type, stride, pointer);
			CallLog("glVertexAttribIPointer({0}, {1}, {2}, {3}, {4})", index, size, type, stride, pointer);
			DebugCheckErrors();
		}

		/// <summary>
		/// define an array of generic vertex attribute data
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="size">
		/// Specifies the number of components per generic vertex attribute. Must be 1, 2, 3, 4. Additionally, the symbolic constant 
		/// GL_BGRA is accepted by glVertexAttribPointer. The initial value is 4.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of each component in the array. The symbolic constants GL_BYTE, GL_UNSIGNED_BYTE, GL_SHORT, 
		/// GL_UNSIGNED_SHORT, GL_INT, and GL_UNSIGNED_INT are accepted by glVertexAttribPointer and glVertexAttribIPointer. 
		/// Additionally GL_HALF_FLOAT, GL_FLOAT, GL_DOUBLE, GL_FIXED, GL_INT_2_10_10_10_REV, GL_UNSIGNED_INT_2_10_10_10_REV and 
		/// GL_UNSIGNED_INT_10F_11F_11F_REV are accepted by glVertexAttribPointer. GL_DOUBLE is also accepted by 
		/// glVertexAttribLPointer and is the only token accepted by the type parameter for that function. The initial value is 
		/// GL_FLOAT.
		/// </param>
		/// <param name="stride">
		/// Specifies the byte offset between consecutive generic vertex attributes. If stride is 0, the generic vertex attributes 
		/// are understood to be tightly packed in the array. The initial value is 0.
		/// </param>
		/// <param name="pointer">
		/// Specifies a offset of the first component of the first generic vertex attribute in the array in the data store of the 
		/// buffer currently bound to the GL_ARRAY_BUFFER target. The initial value is 0.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribIPointer(UInt32 index, Int32 size, int type, Int32 stride, Object pointer)
		{
			GCHandle pin_pointer = GCHandle.Alloc(pointer, GCHandleType.Pinned);
			try {
				VertexAttribIPointer(index, size, type, stride, pin_pointer.AddrOfPinnedObject());
			} finally {
				pin_pointer.Free();
			}
		}

		/// <summary>
		/// Return a generic vertex attribute parameter
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, 
		/// GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_CURRENT_VERTEX_ATTRIB.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void GetVertexAttribI(UInt32 index, int pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribIiv != null, "pglGetVertexAttribIiv not implemented");
					Delegates.pglGetVertexAttribIiv(index, pname, p_params);
					CallLog("glGetVertexAttribIiv({0}, {1}, {2})", index, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Return a generic vertex attribute parameter
		/// </summary>
		/// <param name="index">
		/// Specifies the generic vertex attribute parameter to be queried.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the vertex attribute parameter to be queried. Accepted values are 
		/// GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING, GL_VERTEX_ATTRIB_ARRAY_ENABLED, GL_VERTEX_ATTRIB_ARRAY_SIZE, 
		/// GL_VERTEX_ATTRIB_ARRAY_STRIDE, GL_VERTEX_ATTRIB_ARRAY_TYPE, GL_VERTEX_ATTRIB_ARRAY_NORMALIZED, 
		/// GL_VERTEX_ATTRIB_ARRAY_INTEGER, GL_VERTEX_ATTRIB_ARRAY_DIVISOR, or GL_CURRENT_VERTEX_ATTRIB.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void GetVertexAttribI(UInt32 index, int pname, out UInt32 @params)
		{
			unsafe {
				fixed (UInt32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetVertexAttribIuiv != null, "pglGetVertexAttribIuiv not implemented");
					Delegates.pglGetVertexAttribIuiv(index, pname, p_params);
					CallLog("glGetVertexAttribIuiv({0}, {1}, {2})", index, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI1(UInt32 index, Int32 x)
		{
			Debug.Assert(Delegates.pglVertexAttribI1i != null, "pglVertexAttribI1i not implemented");
			Delegates.pglVertexAttribI1i(index, x);
			CallLog("glVertexAttribI1i({0}, {1})", index, x);
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI2(UInt32 index, Int32 x, Int32 y)
		{
			Debug.Assert(Delegates.pglVertexAttribI2i != null, "pglVertexAttribI2i not implemented");
			Delegates.pglVertexAttribI2i(index, x, y);
			CallLog("glVertexAttribI2i({0}, {1}, {2})", index, x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI3(UInt32 index, Int32 x, Int32 y, Int32 z)
		{
			Debug.Assert(Delegates.pglVertexAttribI3i != null, "pglVertexAttribI3i not implemented");
			Delegates.pglVertexAttribI3i(index, x, y, z);
			CallLog("glVertexAttribI3i({0}, {1}, {2}, {3})", index, x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI4(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglVertexAttribI4i != null, "pglVertexAttribI4i not implemented");
			Delegates.pglVertexAttribI4i(index, x, y, z, w);
			CallLog("glVertexAttribI4i({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI1(UInt32 index, UInt32 x)
		{
			Debug.Assert(Delegates.pglVertexAttribI1ui != null, "pglVertexAttribI1ui not implemented");
			Delegates.pglVertexAttribI1ui(index, x);
			CallLog("glVertexAttribI1ui({0}, {1})", index, x);
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI2(UInt32 index, UInt32 x, UInt32 y)
		{
			Debug.Assert(Delegates.pglVertexAttribI2ui != null, "pglVertexAttribI2ui not implemented");
			Delegates.pglVertexAttribI2ui(index, x, y);
			CallLog("glVertexAttribI2ui({0}, {1}, {2})", index, x, y);
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI3(UInt32 index, UInt32 x, UInt32 y, UInt32 z)
		{
			Debug.Assert(Delegates.pglVertexAttribI3ui != null, "pglVertexAttribI3ui not implemented");
			Delegates.pglVertexAttribI3ui(index, x, y, z);
			CallLog("glVertexAttribI3ui({0}, {1}, {2}, {3})", index, x, y, z);
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="x">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="y">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="z">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="w">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI4(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w)
		{
			Debug.Assert(Delegates.pglVertexAttribI4ui != null, "pglVertexAttribI4ui not implemented");
			Delegates.pglVertexAttribI4ui(index, x, y, z, w);
			CallLog("glVertexAttribI4ui({0}, {1}, {2}, {3}, {4})", index, x, y, z, w);
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI1(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI1iv != null, "pglVertexAttribI1iv not implemented");
					Delegates.pglVertexAttribI1iv(index, p_v);
					CallLog("glVertexAttribI1iv({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI2(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI2iv != null, "pglVertexAttribI2iv not implemented");
					Delegates.pglVertexAttribI2iv(index, p_v);
					CallLog("glVertexAttribI2iv({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI3(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI3iv != null, "pglVertexAttribI3iv not implemented");
					Delegates.pglVertexAttribI3iv(index, p_v);
					CallLog("glVertexAttribI3iv({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI4(UInt32 index, Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI4iv != null, "pglVertexAttribI4iv not implemented");
					Delegates.pglVertexAttribI4iv(index, p_v);
					CallLog("glVertexAttribI4iv({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI1(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI1uiv != null, "pglVertexAttribI1uiv not implemented");
					Delegates.pglVertexAttribI1uiv(index, p_v);
					CallLog("glVertexAttribI1uiv({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI2(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI2uiv != null, "pglVertexAttribI2uiv not implemented");
					Delegates.pglVertexAttribI2uiv(index, p_v);
					CallLog("glVertexAttribI2uiv({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI3(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI3uiv != null, "pglVertexAttribI3uiv not implemented");
					Delegates.pglVertexAttribI3uiv(index, p_v);
					CallLog("glVertexAttribI3uiv({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI4(UInt32 index, UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI4uiv != null, "pglVertexAttribI4uiv not implemented");
					Delegates.pglVertexAttribI4uiv(index, p_v);
					CallLog("glVertexAttribI4uiv({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI4(UInt32 index, sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI4bv != null, "pglVertexAttribI4bv not implemented");
					Delegates.pglVertexAttribI4bv(index, p_v);
					CallLog("glVertexAttribI4bv({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI4(UInt32 index, Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI4sv != null, "pglVertexAttribI4sv not implemented");
					Delegates.pglVertexAttribI4sv(index, p_v);
					CallLog("glVertexAttribI4sv({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI4(UInt32 index, byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI4ubv != null, "pglVertexAttribI4ubv not implemented");
					Delegates.pglVertexAttribI4ubv(index, p_v);
					CallLog("glVertexAttribI4ubv({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specifies the value of a generic vertex attribute
		/// </summary>
		/// <param name="index">
		/// Specifies the index of the generic vertex attribute to be modified.
		/// </param>
		/// <param name="v">
		/// For the vector commands (glVertexAttrib*v), specifies a pointer to an array of values to be used for the generic vertex 
		/// attribute.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void VertexAttribI4(UInt32 index, UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertexAttribI4usv != null, "pglVertexAttribI4usv not implemented");
					Delegates.pglVertexAttribI4usv(index, p_v);
					CallLog("glVertexAttribI4usv({0}, {1})", index, v);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Returns the value of a uniform variable
		/// </summary>
		/// <param name="program">
		/// Specifies the program object to be queried.
		/// </param>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be queried.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void GetUniform(UInt32 program, Int32 location, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetUniformuiv != null, "pglGetUniformuiv not implemented");
					Delegates.pglGetUniformuiv(program, location, p_params);
					CallLog("glGetUniformuiv({0}, {1}, {2})", program, location, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// bind a user-defined varying out variable to a fragment shader color number
		/// </summary>
		/// <param name="program">
		/// The name of the program containing varying out variable whose binding to modify
		/// </param>
		/// <param name="color">
		/// A <see cref="T:UInt32"/>.
		/// </param>
		/// <param name="name">
		/// The name of the user-defined varying out variable whose binding to modify
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void BindFragDataLocation(UInt32 program, UInt32 color, String name)
		{
			Debug.Assert(Delegates.pglBindFragDataLocation != null, "pglBindFragDataLocation not implemented");
			Delegates.pglBindFragDataLocation(program, color, name);
			CallLog("glBindFragDataLocation({0}, {1}, {2})", program, color, name);
			DebugCheckErrors();
		}

		/// <summary>
		/// query the bindings of color numbers to user-defined varying out variables
		/// </summary>
		/// <param name="program">
		/// The name of the program containing varying out variable whose binding to query
		/// </param>
		/// <param name="name">
		/// The name of the user-defined varying out variable whose binding to query
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static Int32 GetFragDataLocation(UInt32 program, String name)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetFragDataLocation != null, "pglGetFragDataLocation not implemented");
			retValue = Delegates.pglGetFragDataLocation(program, name);
			CallLog("glGetFragDataLocation({0}, {1}) = {2}", program, name, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void Uniform1(Int32 location, UInt32 v0)
		{
			Debug.Assert(Delegates.pglUniform1ui != null, "pglUniform1ui not implemented");
			Delegates.pglUniform1ui(location, v0);
			CallLog("glUniform1ui({0}, {1})", location, v0);
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void Uniform2(Int32 location, UInt32 v0, UInt32 v1)
		{
			Debug.Assert(Delegates.pglUniform2ui != null, "pglUniform2ui not implemented");
			Delegates.pglUniform2ui(location, v0, v1);
			CallLog("glUniform2ui({0}, {1}, {2})", location, v0, v1);
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void Uniform3(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2)
		{
			Debug.Assert(Delegates.pglUniform3ui != null, "pglUniform3ui not implemented");
			Delegates.pglUniform3ui(location, v0, v1, v2);
			CallLog("glUniform3ui({0}, {1}, {2}, {3})", location, v0, v1, v2);
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="v0">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v1">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v2">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		/// <param name="v3">
		/// For the scalar commands, specifies the new values to be used for the specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void Uniform4(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3)
		{
			Debug.Assert(Delegates.pglUniform4ui != null, "pglUniform4ui not implemented");
			Delegates.pglUniform4ui(location, v0, v1, v2, v3);
			CallLog("glUniform4ui({0}, {1}, {2}, {3}, {4})", location, v0, v1, v2, v3);
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void Uniform1(Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform1uiv != null, "pglUniform1uiv not implemented");
					Delegates.pglUniform1uiv(location, count, p_value);
					CallLog("glUniform1uiv({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void Uniform2(Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform2uiv != null, "pglUniform2uiv not implemented");
					Delegates.pglUniform2uiv(location, count, p_value);
					CallLog("glUniform2uiv({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void Uniform3(Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform3uiv != null, "pglUniform3uiv not implemented");
					Delegates.pglUniform3uiv(location, count, p_value);
					CallLog("glUniform3uiv({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Specify the value of a uniform variable for the current program object
		/// </summary>
		/// <param name="location">
		/// Specifies the location of the uniform variable to be modified.
		/// </param>
		/// <param name="count">
		/// For the vector (glUniform*v) commands, specifies the number of elements that are to be modified. This should be 1 if the 
		/// targeted uniform variable is not an array, and 1 or more if it is an array.
		/// </param>
		/// <param name="value">
		/// For the vector and matrix commands, specifies a pointer to an array of count values that will be used to update the 
		/// specified uniform variable.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void Uniform4(Int32 location, Int32 count, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglUniform4uiv != null, "pglUniform4uiv not implemented");
					Delegates.pglUniform4uiv(location, count, p_value);
					CallLog("glUniform4uiv({0}, {1}, {2})", location, count, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexParameterIiv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void TexParameterIiv(TextureTarget target, TextureParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterIiv != null, "pglTexParameterIiv not implemented");
					Delegates.pglTexParameterIiv((int)target, (int)pname, p_params);
					CallLog("glTexParameterIiv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// Binding for glTexParameterIuiv.
		/// </summary>
		/// <param name="target">
		/// A <see cref="T:TextureTarget"/>.
		/// </param>
		/// <param name="pname">
		/// A <see cref="T:TextureParameterName"/>.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void TexParameterIuiv(TextureTarget target, TextureParameterName pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterIuiv != null, "pglTexParameterIuiv not implemented");
					Delegates.pglTexParameterIuiv((int)target, (int)pname, p_params);
					CallLog("glTexParameterIuiv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexParameterfv, glGetTexParameteriv, glGetTexParameterIiv, 
		/// and glGetTexParameterIuiv functions. GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_RECTANGLE, 
		/// and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterIiv != null, "pglGetTexParameterIiv not implemented");
					Delegates.pglGetTexParameterIiv((int)target, (int)pname, p_params);
					CallLog("glGetTexParameterIiv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for glGetTexParameterfv, glGetTexParameteriv, glGetTexParameterIiv, 
		/// and glGetTexParameterIuiv functions. GL_TEXTURE_1D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D, GL_TEXTURE_2D_ARRAY, 
		/// GL_TEXTURE_2D_MULTISAMPLE, GL_TEXTURE_2D_MULTISAMPLE_ARRAY, GL_TEXTURE_3D, GL_TEXTURE_CUBE_MAP, GL_TEXTURE_RECTANGLE, 
		/// and GL_TEXTURE_CUBE_MAP_ARRAY are accepted.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. GL_DEPTH_STENCIL_TEXTURE_MODE, GL_IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_COMPARE_MODE, GL_TEXTURE_COMPARE_FUNC, 
		/// GL_TEXTURE_IMMUTABLE_FORMAT, GL_TEXTURE_IMMUTABLE_LEVELS, GL_TEXTURE_LOD_BIAS, GL_TEXTURE_MAG_FILTER, 
		/// GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LOD, GL_TEXTURE_MIN_FILTER, GL_TEXTURE_MIN_LOD, GL_TEXTURE_SWIZZLE_R, 
		/// GL_TEXTURE_SWIZZLE_G, GL_TEXTURE_SWIZZLE_B, GL_TEXTURE_SWIZZLE_A, GL_TEXTURE_SWIZZLE_RGBA, GL_TEXTURE_TARGET, 
		/// GL_TEXTURE_VIEW_MIN_LAYER, GL_TEXTURE_VIEW_MIN_LEVEL, GL_TEXTURE_VIEW_NUM_LAYERS, GL_TEXTURE_VIEW_NUM_LEVELS, 
		/// GL_TEXTURE_WRAP_S, GL_TEXTURE_WRAP_T, and GL_TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, UInt32[] @params)
		{
			unsafe {
				fixed (UInt32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterIuiv != null, "pglGetTexParameterIuiv not implemented");
					Delegates.pglGetTexParameterIuiv((int)target, (int)pname, p_params);
					CallLog("glGetTexParameterIuiv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="buffer">
		/// Specify the buffer to clear.
		/// </param>
		/// <param name="drawbuffer">
		/// Specify a particular draw buffer to clear.
		/// </param>
		/// <param name="value">
		/// A pointer to the value or values to clear the buffer to.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void ClearBuffer(int buffer, Int32 drawbuffer, Int32[] value)
		{
			unsafe {
				fixed (Int32* p_value = value)
				{
					Debug.Assert(Delegates.pglClearBufferiv != null, "pglClearBufferiv not implemented");
					Delegates.pglClearBufferiv(buffer, drawbuffer, p_value);
					CallLog("glClearBufferiv({0}, {1}, {2})", buffer, drawbuffer, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="buffer">
		/// Specify the buffer to clear.
		/// </param>
		/// <param name="drawbuffer">
		/// Specify a particular draw buffer to clear.
		/// </param>
		/// <param name="value">
		/// A pointer to the value or values to clear the buffer to.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void ClearBuffer(int buffer, Int32 drawbuffer, UInt32[] value)
		{
			unsafe {
				fixed (UInt32* p_value = value)
				{
					Debug.Assert(Delegates.pglClearBufferuiv != null, "pglClearBufferuiv not implemented");
					Delegates.pglClearBufferuiv(buffer, drawbuffer, p_value);
					CallLog("glClearBufferuiv({0}, {1}, {2})", buffer, drawbuffer, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="buffer">
		/// Specify the buffer to clear.
		/// </param>
		/// <param name="drawbuffer">
		/// Specify a particular draw buffer to clear.
		/// </param>
		/// <param name="value">
		/// A pointer to the value or values to clear the buffer to.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void ClearBuffer(int buffer, Int32 drawbuffer, float[] value)
		{
			unsafe {
				fixed (float* p_value = value)
				{
					Debug.Assert(Delegates.pglClearBufferfv != null, "pglClearBufferfv not implemented");
					Delegates.pglClearBufferfv(buffer, drawbuffer, p_value);
					CallLog("glClearBufferfv({0}, {1}, {2})", buffer, drawbuffer, value);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// clear individual buffers of a framebuffer
		/// </summary>
		/// <param name="buffer">
		/// Specify the buffer to clear.
		/// </param>
		/// <param name="drawbuffer">
		/// Specify a particular draw buffer to clear.
		/// </param>
		/// <param name="depth">
		/// The value to clear the depth buffer to.
		/// </param>
		/// <param name="stencil">
		/// The value to clear the stencil buffer to.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static void ClearBuffer(int buffer, Int32 drawbuffer, float depth, Int32 stencil)
		{
			Debug.Assert(Delegates.pglClearBufferfi != null, "pglClearBufferfi not implemented");
			Delegates.pglClearBufferfi(buffer, drawbuffer, depth, stencil);
			CallLog("glClearBufferfi({0}, {1}, {2}, {3})", buffer, drawbuffer, depth, stencil);
			DebugCheckErrors();
		}

		/// <summary>
		/// return a string describing the current GL connection
		/// </summary>
		/// <param name="name">
		/// Specifies a symbolic constant, one of GL_VENDOR, GL_RENDERER, GL_VERSION, or GL_SHADING_LANGUAGE_VERSION. Additionally, 
		/// glGetStringi accepts the GL_EXTENSIONS token.
		/// </param>
		/// <param name="index">
		/// For glGetStringi, specifies the index of the string to return.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		public static String GetString(int name, UInt32 index)
		{
			String retValue;

			Debug.Assert(Delegates.pglGetStringi != null, "pglGetStringi not implemented");
			retValue = (String)Marshal.PtrToStringAnsi(Delegates.pglGetStringi(name, index));
			CallLog("glGetStringi({0}, {1}) = {2}", name, index, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// determine if a name corresponds to a renderbuffer object
		/// </summary>
		/// <param name="renderbuffer">
		/// Specifies a value that may be the name of a renderbuffer object.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static bool IsRenderbuffer(UInt32 renderbuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsRenderbuffer != null, "pglIsRenderbuffer not implemented");
			retValue = Delegates.pglIsRenderbuffer(renderbuffer);
			CallLog("glIsRenderbuffer({0}) = {1}", renderbuffer, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// bind a renderbuffer to a renderbuffer target
		/// </summary>
		/// <param name="target">
		/// Specifies the renderbuffer target of the binding operation. target must be GL_RENDERBUFFER.
		/// </param>
		/// <param name="renderbuffer">
		/// Specifies the name of the renderbuffer object to bind.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static void BindRenderbuffer(int target, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglBindRenderbuffer != null, "pglBindRenderbuffer not implemented");
			Delegates.pglBindRenderbuffer(target, renderbuffer);
			CallLog("glBindRenderbuffer({0}, {1})", target, renderbuffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// delete renderbuffer objects
		/// </summary>
		/// <param name="n">
		/// Specifies the number of renderbuffer objects to be deleted.
		/// </param>
		/// <param name="renderbuffers">
		/// A pointer to an array containing n renderbuffer objects to be deleted.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static void DeleteRenderbuffer(params UInt32[] renderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				{
					Debug.Assert(Delegates.pglDeleteRenderbuffers != null, "pglDeleteRenderbuffers not implemented");
					Delegates.pglDeleteRenderbuffers((Int32)renderbuffers.Length, p_renderbuffers);
					CallLog("glDeleteRenderbuffers({0}, {1})", renderbuffers.Length, renderbuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// generate renderbuffer object names
		/// </summary>
		/// <param name="n">
		/// Specifies the number of renderbuffer object names to generate.
		/// </param>
		/// <param name="renderbuffers">
		/// Specifies an array in which the generated renderbuffer object names are stored.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static void GenRenderbuffer(UInt32[] renderbuffers)
		{
			unsafe {
				fixed (UInt32* p_renderbuffers = renderbuffers)
				{
					Debug.Assert(Delegates.pglGenRenderbuffers != null, "pglGenRenderbuffers not implemented");
					Delegates.pglGenRenderbuffers((Int32)renderbuffers.Length, p_renderbuffers);
					CallLog("glGenRenderbuffers({0}, {1})", renderbuffers.Length, renderbuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// generate renderbuffer object names
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static UInt32 GenRenderbuffer()
		{
			UInt32[] retValue = new UInt32[1];
			GenRenderbuffer(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// establish data storage, format and dimensions of a renderbuffer object's image
		/// </summary>
		/// <param name="target">
		/// Specifies a binding target of the allocation for glRenderbufferStorage function. Must be GL_RENDERBUFFER.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format to use for the renderbuffer object's image.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the renderbuffer, in pixels.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the renderbuffer, in pixels.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static void RenderbufferStorage(int target, int internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorage != null, "pglRenderbufferStorage not implemented");
			Delegates.pglRenderbufferStorage(target, internalformat, width, height);
			CallLog("glRenderbufferStorage({0}, {1}, {2}, {3})", target, internalformat, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// query a named parameter of a renderbuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the renderbuffer object is bound for glGetRenderbufferParameteriv. target must be 
		/// GL_RENDERBUFFER.
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of the renderbuffer object to query.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static void GetRenderbufferParameter(int target, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetRenderbufferParameteriv != null, "pglGetRenderbufferParameteriv not implemented");
					Delegates.pglGetRenderbufferParameteriv(target, pname, p_params);
					CallLog("glGetRenderbufferParameteriv({0}, {1}, {2})", target, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// determine if a name corresponds to a framebuffer object
		/// </summary>
		/// <param name="framebuffer">
		/// Specifies a value that may be the name of a framebuffer object.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static bool IsFramebuffer(UInt32 framebuffer)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsFramebuffer != null, "pglIsFramebuffer not implemented");
			retValue = Delegates.pglIsFramebuffer(framebuffer);
			CallLog("glIsFramebuffer({0}) = {1}", framebuffer, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// bind a framebuffer to a framebuffer target
		/// </summary>
		/// <param name="target">
		/// Specifies the framebuffer target of the binding operation.
		/// </param>
		/// <param name="framebuffer">
		/// Specifies the name of the framebuffer object to bind.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static void BindFramebuffer(int target, UInt32 framebuffer)
		{
			Debug.Assert(Delegates.pglBindFramebuffer != null, "pglBindFramebuffer not implemented");
			Delegates.pglBindFramebuffer(target, framebuffer);
			CallLog("glBindFramebuffer({0}, {1})", target, framebuffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// delete framebuffer objects
		/// </summary>
		/// <param name="n">
		/// Specifies the number of framebuffer objects to be deleted.
		/// </param>
		/// <param name="framebuffers">
		/// A pointer to an array containing n framebuffer objects to be deleted.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static void DeleteFramebuffers(params UInt32[] framebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				{
					Debug.Assert(Delegates.pglDeleteFramebuffers != null, "pglDeleteFramebuffers not implemented");
					Delegates.pglDeleteFramebuffers((Int32)framebuffers.Length, p_framebuffers);
					CallLog("glDeleteFramebuffers({0}, {1})", framebuffers.Length, framebuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// generate framebuffer object names
		/// </summary>
		/// <param name="n">
		/// Specifies the number of framebuffer object names to generate.
		/// </param>
		/// <param name="framebuffers">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static void GenFramebuffers(UInt32[] framebuffers)
		{
			unsafe {
				fixed (UInt32* p_framebuffers = framebuffers)
				{
					Debug.Assert(Delegates.pglGenFramebuffers != null, "pglGenFramebuffers not implemented");
					Delegates.pglGenFramebuffers((Int32)framebuffers.Length, p_framebuffers);
					CallLog("glGenFramebuffers({0}, {1})", framebuffers.Length, framebuffers);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// generate framebuffer object names
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static UInt32 GenFramebuffer()
		{
			UInt32[] retValue = new UInt32[1];
			GenFramebuffers(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// check the completeness status of a framebuffer
		/// </summary>
		/// <param name="target">
		/// Specify the target to which the framebuffer is bound for glCheckFramebufferStatus, and the target against which 
		/// framebuffer completeness of framebuffer is checked for glCheckNamedFramebufferStatus.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static int CheckFramebufferStatus(int target)
		{
			int retValue;

			Debug.Assert(Delegates.pglCheckFramebufferStatus != null, "pglCheckFramebufferStatus not implemented");
			retValue = Delegates.pglCheckFramebufferStatus(target);
			CallLog("glCheckFramebufferStatus({0}) = {1}", target, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// attach a level of a texture object as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer is bound for all commands exceptglNamedFramebufferTexture.
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment point of the framebuffer.
		/// </param>
		/// <param name="textarget">
		/// For glFramebufferTexture1D, glFramebufferTexture2D and glFramebufferTexture3D, specifies what type of texture is 
		/// expected in the texture parameter, or for cube map textures, which face is to be attached.
		/// </param>
		/// <param name="texture">
		/// Specifies the name of an existing texture object to attach.
		/// </param>
		/// <param name="level">
		/// Specifies the mipmap level of the texture object to attach.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static void FramebufferTexture1D(int target, int attachment, int textarget, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglFramebufferTexture1D != null, "pglFramebufferTexture1D not implemented");
			Delegates.pglFramebufferTexture1D(target, attachment, textarget, texture, level);
			CallLog("glFramebufferTexture1D({0}, {1}, {2}, {3}, {4})", target, attachment, textarget, texture, level);
			DebugCheckErrors();
		}

		/// <summary>
		/// attach a level of a texture object as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer is bound for all commands exceptglNamedFramebufferTexture.
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment point of the framebuffer.
		/// </param>
		/// <param name="textarget">
		/// For glFramebufferTexture1D, glFramebufferTexture2D and glFramebufferTexture3D, specifies what type of texture is 
		/// expected in the texture parameter, or for cube map textures, which face is to be attached.
		/// </param>
		/// <param name="texture">
		/// Specifies the name of an existing texture object to attach.
		/// </param>
		/// <param name="level">
		/// Specifies the mipmap level of the texture object to attach.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static void FramebufferTexture2D(int target, int attachment, int textarget, UInt32 texture, Int32 level)
		{
			Debug.Assert(Delegates.pglFramebufferTexture2D != null, "pglFramebufferTexture2D not implemented");
			Delegates.pglFramebufferTexture2D(target, attachment, textarget, texture, level);
			CallLog("glFramebufferTexture2D({0}, {1}, {2}, {3}, {4})", target, attachment, textarget, texture, level);
			DebugCheckErrors();
		}

		/// <summary>
		/// attach a level of a texture object as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer is bound for all commands exceptglNamedFramebufferTexture.
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment point of the framebuffer.
		/// </param>
		/// <param name="textarget">
		/// For glFramebufferTexture1D, glFramebufferTexture2D and glFramebufferTexture3D, specifies what type of texture is 
		/// expected in the texture parameter, or for cube map textures, which face is to be attached.
		/// </param>
		/// <param name="texture">
		/// Specifies the name of an existing texture object to attach.
		/// </param>
		/// <param name="level">
		/// Specifies the mipmap level of the texture object to attach.
		/// </param>
		/// <param name="zoffset">
		/// A <see cref="T:Int32"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static void FramebufferTexture3D(int target, int attachment, int textarget, UInt32 texture, Int32 level, Int32 zoffset)
		{
			Debug.Assert(Delegates.pglFramebufferTexture3D != null, "pglFramebufferTexture3D not implemented");
			Delegates.pglFramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
			CallLog("glFramebufferTexture3D({0}, {1}, {2}, {3}, {4}, {5})", target, attachment, textarget, texture, level, zoffset);
			DebugCheckErrors();
		}

		/// <summary>
		/// attach a renderbuffer as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer is bound for glFramebufferRenderbuffer.
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment point of the framebuffer.
		/// </param>
		/// <param name="renderbuffertarget">
		/// Specifies the renderbuffer target. Must be GL_RENDERBUFFER.
		/// </param>
		/// <param name="renderbuffer">
		/// Specifies the name of an existing renderbuffer object of type renderbuffertarget to attach.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static void FramebufferRenderbuffer(int target, int attachment, int renderbuffertarget, UInt32 renderbuffer)
		{
			Debug.Assert(Delegates.pglFramebufferRenderbuffer != null, "pglFramebufferRenderbuffer not implemented");
			Delegates.pglFramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
			CallLog("glFramebufferRenderbuffer({0}, {1}, {2}, {3})", target, attachment, renderbuffertarget, renderbuffer);
			DebugCheckErrors();
		}

		/// <summary>
		/// retrieve information about attachments of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer object is bound for glGetFramebufferAttachmentParameteriv.
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment of the framebuffer object to query.
		/// </param>
		/// <param name="pname">
		/// Specifies the parameter of attachment to query.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static void GetFramebufferAttachmentParameter(int target, int attachment, int pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetFramebufferAttachmentParameteriv != null, "pglGetFramebufferAttachmentParameteriv not implemented");
					Delegates.pglGetFramebufferAttachmentParameteriv(target, attachment, pname, p_params);
					CallLog("glGetFramebufferAttachmentParameteriv({0}, {1}, {2}, {3})", target, attachment, pname, @params);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// generate mipmaps for a specified texture object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture object is bound for glGenerateMipmap. Must be one of GL_TEXTURE_1D, 
		/// GL_TEXTURE_2D, GL_TEXTURE_3D, GL_TEXTURE_1D_ARRAY, GL_TEXTURE_2D_ARRAY, GL_TEXTURE_CUBE_MAP, or 
		/// GL_TEXTURE_CUBE_MAP_ARRAY.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static void GenerateMipmap(int target)
		{
			Debug.Assert(Delegates.pglGenerateMipmap != null, "pglGenerateMipmap not implemented");
			Delegates.pglGenerateMipmap(target);
			CallLog("glGenerateMipmap({0})", target);
			DebugCheckErrors();
		}

		/// <summary>
		/// copy a block of pixels from one framebuffer object to another
		/// </summary>
		/// <param name="srcX0">
		/// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
		/// </param>
		/// <param name="srcY0">
		/// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
		/// </param>
		/// <param name="srcX1">
		/// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
		/// </param>
		/// <param name="srcY1">
		/// Specify the bounds of the source rectangle within the read buffer of the read framebuffer.
		/// </param>
		/// <param name="dstX0">
		/// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
		/// </param>
		/// <param name="dstY0">
		/// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
		/// </param>
		/// <param name="dstX1">
		/// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
		/// </param>
		/// <param name="dstY1">
		/// Specify the bounds of the destination rectangle within the write buffer of the write framebuffer.
		/// </param>
		/// <param name="mask">
		/// The bitwise OR of the flags indicating which buffers are to be copied. The allowed flags are GL_COLOR_BUFFER_BIT, 
		/// GL_DEPTH_BUFFER_BIT and GL_STENCIL_BUFFER_BIT.
		/// </param>
		/// <param name="filter">
		/// Specifies the interpolation to be applied if the image is stretched. Must be GL_NEAREST or GL_LINEAR.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, ClearBufferMask mask, int filter)
		{
			Debug.Assert(Delegates.pglBlitFramebuffer != null, "pglBlitFramebuffer not implemented");
			Delegates.pglBlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, (uint)mask, filter);
			CallLog("glBlitFramebuffer({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9})", srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			DebugCheckErrors();
		}

		/// <summary>
		/// establish data storage, format, dimensions and sample count of a renderbuffer object's image
		/// </summary>
		/// <param name="target">
		/// Specifies a binding target of the allocation for glRenderbufferStorageMultisample function. Must be GL_RENDERBUFFER.
		/// </param>
		/// <param name="samples">
		/// Specifies the number of samples to be used for the renderbuffer object's storage.
		/// </param>
		/// <param name="internalformat">
		/// Specifies the internal format to use for the renderbuffer object's image.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the renderbuffer, in pixels.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the renderbuffer, in pixels.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static void RenderbufferStorageMultisample(int target, Int32 samples, int internalformat, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglRenderbufferStorageMultisample != null, "pglRenderbufferStorageMultisample not implemented");
			Delegates.pglRenderbufferStorageMultisample(target, samples, internalformat, width, height);
			CallLog("glRenderbufferStorageMultisample({0}, {1}, {2}, {3}, {4})", target, samples, internalformat, width, height);
			DebugCheckErrors();
		}

		/// <summary>
		/// attach a single layer of a texture object as a logical buffer of a framebuffer object
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the framebuffer is bound for glFramebufferTextureLayer.
		/// </param>
		/// <param name="attachment">
		/// Specifies the attachment point of the framebuffer.
		/// </param>
		/// <param name="texture">
		/// Specifies the name of an existing texture object to attach.
		/// </param>
		/// <param name="level">
		/// Specifies the mipmap level of the texture object to attach.
		/// </param>
		/// <param name="layer">
		/// Specifies the layer of the texture object to attach.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object")]
		public static void FramebufferTextureLayer(int target, int attachment, UInt32 texture, Int32 level, Int32 layer)
		{
			Debug.Assert(Delegates.pglFramebufferTextureLayer != null, "pglFramebufferTextureLayer not implemented");
			Delegates.pglFramebufferTextureLayer(target, attachment, texture, level, layer);
			CallLog("glFramebufferTextureLayer({0}, {1}, {2}, {3}, {4})", target, attachment, texture, level, layer);
			DebugCheckErrors();
		}

		/// <summary>
		/// map all or part of a buffer object's data store into the client's address space
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glMapBufferRange, which must be one of the buffer binding 
		/// targets in the following table:
		/// </param>
		/// <param name="offset">
		/// Specifies the starting offset within the buffer of the range to be mapped.
		/// </param>
		/// <param name="length">
		/// Specifies the length of the range to be mapped.
		/// </param>
		/// <param name="access">
		/// Specifies a combination of access flags indicating the desired access to the mapped range.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_map_buffer_range")]
		public static IntPtr MapBufferRange(BufferTargetARB target, IntPtr offset, UInt32 length, uint access)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglMapBufferRange != null, "pglMapBufferRange not implemented");
			retValue = Delegates.pglMapBufferRange((int)target, offset, length, access);
			CallLog("glMapBufferRange({0}, {1}, {2}, {3}) = {4}", target, offset, length, access, retValue);
			DebugCheckErrors();

			return (retValue);
		}

		/// <summary>
		/// indicate modifications to a range of a mapped buffer
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the buffer object is bound for glFlushMappedBufferRange, which must be one of the buffer 
		/// binding targets in the following table:
		/// </param>
		/// <param name="offset">
		/// Specifies the start of the buffer subrange, in basic machine units.
		/// </param>
		/// <param name="length">
		/// Specifies the length of the buffer subrange, in basic machine units.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_map_buffer_range")]
		public static void FlushMappedBufferRange(BufferTargetARB target, IntPtr offset, UInt32 length)
		{
			Debug.Assert(Delegates.pglFlushMappedBufferRange != null, "pglFlushMappedBufferRange not implemented");
			Delegates.pglFlushMappedBufferRange((int)target, offset, length);
			CallLog("glFlushMappedBufferRange({0}, {1}, {2})", target, offset, length);
			DebugCheckErrors();
		}

		/// <summary>
		/// bind a vertex array object
		/// </summary>
		/// <param name="array">
		/// Specifies the name of the vertex array to bind.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_vertex_array_object")]
		public static void BindVertexArray(UInt32 array)
		{
			Debug.Assert(Delegates.pglBindVertexArray != null, "pglBindVertexArray not implemented");
			Delegates.pglBindVertexArray(array);
			CallLog("glBindVertexArray({0})", array);
			DebugCheckErrors();
		}

		/// <summary>
		/// delete vertex array objects
		/// </summary>
		/// <param name="n">
		/// Specifies the number of vertex array objects to be deleted.
		/// </param>
		/// <param name="arrays">
		/// Specifies the address of an array containing the n names of the objects to be deleted.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_vertex_array_object")]
		public static void DeleteVertexArrays(params UInt32[] arrays)
		{
			unsafe {
				fixed (UInt32* p_arrays = arrays)
				{
					Debug.Assert(Delegates.pglDeleteVertexArrays != null, "pglDeleteVertexArrays not implemented");
					Delegates.pglDeleteVertexArrays((Int32)arrays.Length, p_arrays);
					CallLog("glDeleteVertexArrays({0}, {1})", arrays.Length, arrays);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// generate vertex array object names
		/// </summary>
		/// <param name="n">
		/// Specifies the number of vertex array object names to generate.
		/// </param>
		/// <param name="arrays">
		/// Specifies an array in which the generated vertex array object names are stored.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_vertex_array_object")]
		public static void GenVertexArrays(UInt32[] arrays)
		{
			unsafe {
				fixed (UInt32* p_arrays = arrays)
				{
					Debug.Assert(Delegates.pglGenVertexArrays != null, "pglGenVertexArrays not implemented");
					Delegates.pglGenVertexArrays((Int32)arrays.Length, p_arrays);
					CallLog("glGenVertexArrays({0}, {1})", arrays.Length, arrays);
				}
			}
			DebugCheckErrors();
		}

		/// <summary>
		/// generate vertex array object names
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_vertex_array_object")]
		public static UInt32 GenVertexArray()
		{
			UInt32[] retValue = new UInt32[1];
			GenVertexArrays(retValue);
			return (retValue[0]);
		}

		/// <summary>
		/// determine if a name corresponds to a vertex array object
		/// </summary>
		/// <param name="array">
		/// Specifies a value that may be the name of a vertex array object.
		/// </param>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_vertex_array_object")]
		public static bool IsVertexArray(UInt32 array)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsVertexArray != null, "pglIsVertexArray not implemented");
			retValue = Delegates.pglIsVertexArray(array);
			CallLog("glIsVertexArray({0}) = {1}", array, retValue);
			DebugCheckErrors();

			return (retValue);
		}

	}

}