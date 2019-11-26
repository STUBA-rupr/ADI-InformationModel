/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua.Di;
using Opc.Ua;

namespace Opc.Ua.Ws
{
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the WeightScaleType_Lock_InitLock Method.
        /// </summary>
        public const uint WeightScaleType_Lock_InitLock = 15283;

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_RenewLock Method.
        /// </summary>
        public const uint WeightScaleType_Lock_RenewLock = 15286;

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_ExitLock Method.
        /// </summary>
        public const uint WeightScaleType_Lock_ExitLock = 15288;

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_BreakLock Method.
        /// </summary>
        public const uint WeightScaleType_Lock_BreakLock = 15290;

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint WeightScaleType_CPIdentifier_Lock_InitLock = 15318;

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint WeightScaleType_CPIdentifier_Lock_RenewLock = 15321;

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint WeightScaleType_CPIdentifier_Lock_ExitLock = 15323;

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint WeightScaleType_CPIdentifier_Lock_BreakLock = 15325;

        /// <summary>
        /// The identifier for the WeightScaleType_MethodSet_Tare Method.
        /// </summary>
        public const uint WeightScaleType_MethodSet_Tare = 15345;

        /// <summary>
        /// The identifier for the WeightScaleType_MethodSet_Zero Method.
        /// </summary>
        public const uint WeightScaleType_MethodSet_Zero = 15346;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_InitLock Method.
        /// </summary>
        public const uint MettlerToledoPR802_Lock_InitLock = 15194;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_RenewLock Method.
        /// </summary>
        public const uint MettlerToledoPR802_Lock_RenewLock = 15197;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_ExitLock Method.
        /// </summary>
        public const uint MettlerToledoPR802_Lock_ExitLock = 15199;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_BreakLock Method.
        /// </summary>
        public const uint MettlerToledoPR802_Lock_BreakLock = 15201;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint MettlerToledoPR802_CPIdentifier_Lock_InitLock = 15229;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint MettlerToledoPR802_CPIdentifier_Lock_RenewLock = 15232;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint MettlerToledoPR802_CPIdentifier_Lock_ExitLock = 15234;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint MettlerToledoPR802_CPIdentifier_Lock_BreakLock = 15236;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_Tare Method.
        /// </summary>
        public const uint MettlerToledoPR802_MethodSet_Tare = 15256;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_Zero Method.
        /// </summary>
        public const uint MettlerToledoPR802_MethodSet_Zero = 15257;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_Connect Method.
        /// </summary>
        public const uint MettlerToledoPR802_MethodSet_COM_Connect = 15349;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_IsConnected Method.
        /// </summary>
        public const uint MettlerToledoPR802_MethodSet_COM_IsConnected = 15352;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_SendMTSICSCommand Method.
        /// </summary>
        public const uint MettlerToledoPR802_MethodSet_COM_SendMTSICSCommand = 15354;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_Disconect Method.
        /// </summary>
        public const uint MettlerToledoPR802_MethodSet_COM_Disconect = 15357;

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_InitLock Method.
        /// </summary>
        public const uint PR802_BV020_Lock_InitLock = 15093;

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_RenewLock Method.
        /// </summary>
        public const uint PR802_BV020_Lock_RenewLock = 15096;

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_ExitLock Method.
        /// </summary>
        public const uint PR802_BV020_Lock_ExitLock = 15098;

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_BreakLock Method.
        /// </summary>
        public const uint PR802_BV020_Lock_BreakLock = 15100;

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint PR802_BV020_CPIdentifier_Lock_InitLock = 15128;

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint PR802_BV020_CPIdentifier_Lock_RenewLock = 15131;

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint PR802_BV020_CPIdentifier_Lock_ExitLock = 15133;

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint PR802_BV020_CPIdentifier_Lock_BreakLock = 15135;

        /// <summary>
        /// The identifier for the PR802_BV020_MethodSet_Tare Method.
        /// </summary>
        public const uint PR802_BV020_MethodSet_Tare = 15155;

        /// <summary>
        /// The identifier for the PR802_BV020_MethodSet_Zero Method.
        /// </summary>
        public const uint PR802_BV020_MethodSet_Zero = 15156;

        /// <summary>
        /// The identifier for the PR802_BV020_MethodSet_COM_Connect Method.
        /// </summary>
        public const uint PR802_BV020_MethodSet_COM_Connect = 15170;

        /// <summary>
        /// The identifier for the PR802_BV020_MethodSet_COM_IsConnected Method.
        /// </summary>
        public const uint PR802_BV020_MethodSet_COM_IsConnected = 15175;

        /// <summary>
        /// The identifier for the PR802_BV020_MethodSet_COM_SendMTSICSCommand Method.
        /// </summary>
        public const uint PR802_BV020_MethodSet_COM_SendMTSICSCommand = 15177;

        /// <summary>
        /// The identifier for the PR802_BV020_MethodSet_COM_Disconect Method.
        /// </summary>
        public const uint PR802_BV020_MethodSet_COM_Disconect = 15180;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the WeightScaleType_ParameterSet Object.
        /// </summary>
        public const uint WeightScaleType_ParameterSet = 15270;

        /// <summary>
        /// The identifier for the WeightScaleType_MethodSet Object.
        /// </summary>
        public const uint WeightScaleType_MethodSet = 15272;

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint WeightScaleType_CPIdentifier_NetworkAddress = 15327;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet Object.
        /// </summary>
        public const uint MettlerToledoPR802_ParameterSet = 15174;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet Object.
        /// </summary>
        public const uint MettlerToledoPR802_MethodSet = 15183;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint MettlerToledoPR802_CPIdentifier_NetworkAddress = 15238;

        /// <summary>
        /// The identifier for the PR802_BV020 Object.
        /// </summary>
        public const uint PR802_BV020 = 15079;

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet Object.
        /// </summary>
        public const uint PR802_BV020_ParameterSet = 15080;

        /// <summary>
        /// The identifier for the PR802_BV020_MethodSet Object.
        /// </summary>
        public const uint PR802_BV020_MethodSet = 15082;

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint PR802_BV020_CPIdentifier_NetworkAddress = 15137;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the WeightScaleType ObjectType.
        /// </summary>
        public const uint WeightScaleType = 15269;

        /// <summary>
        /// The identifier for the MettlerToledoPR802 ObjectType.
        /// </summary>
        public const uint MettlerToledoPR802 = 15173;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the WeightScaleType_Lock_Locked Variable.
        /// </summary>
        public const uint WeightScaleType_Lock_Locked = 15279;

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_LockingClient Variable.
        /// </summary>
        public const uint WeightScaleType_Lock_LockingClient = 15280;

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_LockingUser Variable.
        /// </summary>
        public const uint WeightScaleType_Lock_LockingUser = 15281;

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint WeightScaleType_Lock_RemainingLockTime = 15282;

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint WeightScaleType_Lock_InitLock_InputArguments = 15284;

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint WeightScaleType_Lock_InitLock_OutputArguments = 15285;

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint WeightScaleType_Lock_RenewLock_OutputArguments = 15287;

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint WeightScaleType_Lock_ExitLock_OutputArguments = 15289;

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint WeightScaleType_Lock_BreakLock_OutputArguments = 15291;

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint WeightScaleType_CPIdentifier_Lock_Locked = 15314;

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint WeightScaleType_CPIdentifier_Lock_LockingClient = 15315;

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint WeightScaleType_CPIdentifier_Lock_LockingUser = 15316;

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint WeightScaleType_CPIdentifier_Lock_RemainingLockTime = 15317;

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint WeightScaleType_CPIdentifier_Lock_InitLock_InputArguments = 15319;

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint WeightScaleType_CPIdentifier_Lock_InitLock_OutputArguments = 15320;

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint WeightScaleType_CPIdentifier_Lock_RenewLock_OutputArguments = 15322;

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint WeightScaleType_CPIdentifier_Lock_ExitLock_OutputArguments = 15324;

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint WeightScaleType_CPIdentifier_Lock_BreakLock_OutputArguments = 15326;

        /// <summary>
        /// The identifier for the WeightScaleType_ParameterSet_weightScale Variable.
        /// </summary>
        public const uint WeightScaleType_ParameterSet_weightScale = 15339;

        /// <summary>
        /// The identifier for the WeightScaleType_ParameterSet_weightScale_InstrumentRange Variable.
        /// </summary>
        public const uint WeightScaleType_ParameterSet_weightScale_InstrumentRange = 15342;

        /// <summary>
        /// The identifier for the WeightScaleType_ParameterSet_weightScale_EURange Variable.
        /// </summary>
        public const uint WeightScaleType_ParameterSet_weightScale_EURange = 15343;

        /// <summary>
        /// The identifier for the WeightScaleType_ParameterSet_weightScale_EngineeringUnits Variable.
        /// </summary>
        public const uint WeightScaleType_ParameterSet_weightScale_EngineeringUnits = 15344;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_Locked Variable.
        /// </summary>
        public const uint MettlerToledoPR802_Lock_Locked = 15190;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_LockingClient Variable.
        /// </summary>
        public const uint MettlerToledoPR802_Lock_LockingClient = 15191;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_LockingUser Variable.
        /// </summary>
        public const uint MettlerToledoPR802_Lock_LockingUser = 15192;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint MettlerToledoPR802_Lock_RemainingLockTime = 15193;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint MettlerToledoPR802_Lock_InitLock_InputArguments = 15195;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint MettlerToledoPR802_Lock_InitLock_OutputArguments = 15196;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint MettlerToledoPR802_Lock_RenewLock_OutputArguments = 15198;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint MettlerToledoPR802_Lock_ExitLock_OutputArguments = 15200;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint MettlerToledoPR802_Lock_BreakLock_OutputArguments = 15202;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Manufacturer Variable.
        /// </summary>
        public const uint MettlerToledoPR802_Manufacturer = 15203;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Model Variable.
        /// </summary>
        public const uint MettlerToledoPR802_Model = 15205;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_DeviceClass Variable.
        /// </summary>
        public const uint MettlerToledoPR802_DeviceClass = 15211;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_SerialNumber Variable.
        /// </summary>
        public const uint MettlerToledoPR802_SerialNumber = 15212;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint MettlerToledoPR802_CPIdentifier_Lock_Locked = 15225;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint MettlerToledoPR802_CPIdentifier_Lock_LockingClient = 15226;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint MettlerToledoPR802_CPIdentifier_Lock_LockingUser = 15227;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint MettlerToledoPR802_CPIdentifier_Lock_RemainingLockTime = 15228;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint MettlerToledoPR802_CPIdentifier_Lock_InitLock_InputArguments = 15230;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint MettlerToledoPR802_CPIdentifier_Lock_InitLock_OutputArguments = 15231;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint MettlerToledoPR802_CPIdentifier_Lock_RenewLock_OutputArguments = 15233;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint MettlerToledoPR802_CPIdentifier_Lock_ExitLock_OutputArguments = 15235;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint MettlerToledoPR802_CPIdentifier_Lock_BreakLock_OutputArguments = 15237;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_weightScale_EngineeringUnits Variable.
        /// </summary>
        public const uint MettlerToledoPR802_ParameterSet_weightScale_EngineeringUnits = 15255;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_COM_SerialPort_Status Variable.
        /// </summary>
        public const uint MettlerToledoPR802_ParameterSet_COM_SerialPort_Status = 15258;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_StaticScale_Filler_01.WV_STABLE Variable.
        /// </summary>
        public const uint MettlerToledoPR802_ParameterSet_StaticScale_Filler_01.WV_STABLE = 15259;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_StaticScale_Filler_01.WV Variable.
        /// </summary>
        public const uint MettlerToledoPR802_ParameterSet_StaticScale_Filler_01.WV = 15260;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_StaticScale_Filler_01.COMMAND_SI Variable.
        /// </summary>
        public const uint MettlerToledoPR802_ParameterSet_StaticScale_Filler_01.COMMAND_SI = 15261;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_StaticScale_Filler_02.WV_STABLE Variable.
        /// </summary>
        public const uint MettlerToledoPR802_ParameterSet_StaticScale_Filler_02.WV_STABLE = 15262;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_StaticScale_Filler_02.WV Variable.
        /// </summary>
        public const uint MettlerToledoPR802_ParameterSet_StaticScale_Filler_02.WV = 15263;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_StaticScale_Filler_02.COMMAND_SI Variable.
        /// </summary>
        public const uint MettlerToledoPR802_ParameterSet_StaticScale_Filler_02.COMMAND_SI = 15264;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_StaticScale_Filler_03.WV_STABLE Variable.
        /// </summary>
        public const uint MettlerToledoPR802_ParameterSet_StaticScale_Filler_03.WV_STABLE = 15265;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_StaticScale_Filler_03.WV Variable.
        /// </summary>
        public const uint MettlerToledoPR802_ParameterSet_StaticScale_Filler_03.WV = 15266;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_StaticScale_Filler_03.COMMAND_SI Variable.
        /// </summary>
        public const uint MettlerToledoPR802_ParameterSet_StaticScale_Filler_03.COMMAND_SI = 15267;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_SC_NetWeight Variable.
        /// </summary>
        public const uint MettlerToledoPR802_ParameterSet_SC_NetWeight = 15268;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_SC_Status Variable.
        /// </summary>
        public const uint MettlerToledoPR802_ParameterSet_SC_Status = 15347;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_SC_StabilityIndicator Variable.
        /// </summary>
        public const uint MettlerToledoPR802_ParameterSet_SC_StabilityIndicator = 15348;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_Connect_InputArguments Variable.
        /// </summary>
        public const uint MettlerToledoPR802_MethodSet_COM_Connect_InputArguments = 15350;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_Connect_OutputArguments Variable.
        /// </summary>
        public const uint MettlerToledoPR802_MethodSet_COM_Connect_OutputArguments = 15351;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_IsConnected_OutputArguments Variable.
        /// </summary>
        public const uint MettlerToledoPR802_MethodSet_COM_IsConnected_OutputArguments = 15353;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_SendMTSICSCommand_InputArguments Variable.
        /// </summary>
        public const uint MettlerToledoPR802_MethodSet_COM_SendMTSICSCommand_InputArguments = 15355;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_SendMTSICSCommand_OutputArguments Variable.
        /// </summary>
        public const uint MettlerToledoPR802_MethodSet_COM_SendMTSICSCommand_OutputArguments = 15356;

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_Disconect_OutputArguments Variable.
        /// </summary>
        public const uint MettlerToledoPR802_MethodSet_COM_Disconect_OutputArguments = 15358;

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_Locked Variable.
        /// </summary>
        public const uint PR802_BV020_Lock_Locked = 15089;

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_LockingClient Variable.
        /// </summary>
        public const uint PR802_BV020_Lock_LockingClient = 15090;

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_LockingUser Variable.
        /// </summary>
        public const uint PR802_BV020_Lock_LockingUser = 15091;

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint PR802_BV020_Lock_RemainingLockTime = 15092;

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint PR802_BV020_Lock_InitLock_InputArguments = 15094;

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint PR802_BV020_Lock_InitLock_OutputArguments = 15095;

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint PR802_BV020_Lock_RenewLock_OutputArguments = 15097;

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint PR802_BV020_Lock_ExitLock_OutputArguments = 15099;

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint PR802_BV020_Lock_BreakLock_OutputArguments = 15101;

        /// <summary>
        /// The identifier for the PR802_BV020_Manufacturer Variable.
        /// </summary>
        public const uint PR802_BV020_Manufacturer = 15102;

        /// <summary>
        /// The identifier for the PR802_BV020_Model Variable.
        /// </summary>
        public const uint PR802_BV020_Model = 15104;

        /// <summary>
        /// The identifier for the PR802_BV020_HardwareRevision Variable.
        /// </summary>
        public const uint PR802_BV020_HardwareRevision = 15105;

        /// <summary>
        /// The identifier for the PR802_BV020_SoftwareRevision Variable.
        /// </summary>
        public const uint PR802_BV020_SoftwareRevision = 15106;

        /// <summary>
        /// The identifier for the PR802_BV020_DeviceRevision Variable.
        /// </summary>
        public const uint PR802_BV020_DeviceRevision = 15107;

        /// <summary>
        /// The identifier for the PR802_BV020_DeviceManual Variable.
        /// </summary>
        public const uint PR802_BV020_DeviceManual = 15109;

        /// <summary>
        /// The identifier for the PR802_BV020_DeviceClass Variable.
        /// </summary>
        public const uint PR802_BV020_DeviceClass = 15110;

        /// <summary>
        /// The identifier for the PR802_BV020_SerialNumber Variable.
        /// </summary>
        public const uint PR802_BV020_SerialNumber = 15111;

        /// <summary>
        /// The identifier for the PR802_BV020_RevisionCounter Variable.
        /// </summary>
        public const uint PR802_BV020_RevisionCounter = 15113;

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint PR802_BV020_CPIdentifier_Lock_Locked = 15124;

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint PR802_BV020_CPIdentifier_Lock_LockingClient = 15125;

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint PR802_BV020_CPIdentifier_Lock_LockingUser = 15126;

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint PR802_BV020_CPIdentifier_Lock_RemainingLockTime = 15127;

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint PR802_BV020_CPIdentifier_Lock_InitLock_InputArguments = 15129;

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint PR802_BV020_CPIdentifier_Lock_InitLock_OutputArguments = 15130;

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint PR802_BV020_CPIdentifier_Lock_RenewLock_OutputArguments = 15132;

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint PR802_BV020_CPIdentifier_Lock_ExitLock_OutputArguments = 15134;

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint PR802_BV020_CPIdentifier_Lock_BreakLock_OutputArguments = 15136;

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_weightScale_EngineeringUnits Variable.
        /// </summary>
        public const uint PR802_BV020_ParameterSet_weightScale_EngineeringUnits = 15154;

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_COM_SerialPort_Status Variable.
        /// </summary>
        public const uint PR802_BV020_ParameterSet_COM_SerialPort_Status = 15157;

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_StaticScale_Filler_01.WV_STABLE Variable.
        /// </summary>
        public const uint PR802_BV020_ParameterSet_StaticScale_Filler_01.WV_STABLE = 15158;

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_StaticScale_Filler_01.WV Variable.
        /// </summary>
        public const uint PR802_BV020_ParameterSet_StaticScale_Filler_01.WV = 15159;

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_StaticScale_Filler_01.COMMAND_SI Variable.
        /// </summary>
        public const uint PR802_BV020_ParameterSet_StaticScale_Filler_01.COMMAND_SI = 15160;

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_StaticScale_Filler_02.WV_STABLE Variable.
        /// </summary>
        public const uint PR802_BV020_ParameterSet_StaticScale_Filler_02.WV_STABLE = 15161;

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_StaticScale_Filler_02.WV Variable.
        /// </summary>
        public const uint PR802_BV020_ParameterSet_StaticScale_Filler_02.WV = 15162;

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_StaticScale_Filler_02.COMMAND_SI Variable.
        /// </summary>
        public const uint PR802_BV020_ParameterSet_StaticScale_Filler_02.COMMAND_SI = 15163;

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_StaticScale_Filler_03.WV_STABLE Variable.
        /// </summary>
        public const uint PR802_BV020_ParameterSet_StaticScale_Filler_03.WV_STABLE = 15164;

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_StaticScale_Filler_03.WV Variable.
        /// </summary>
        public const uint PR802_BV020_ParameterSet_StaticScale_Filler_03.WV = 15165;

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_StaticScale_Filler_03.COMMAND_SI Variable.
        /// </summary>
        public const uint PR802_BV020_ParameterSet_StaticScale_Filler_03.COMMAND_SI = 15166;

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_SC_NetWeight Variable.
        /// </summary>
        public const uint PR802_BV020_ParameterSet_SC_NetWeight = 15167;

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_SC_Status Variable.
        /// </summary>
        public const uint PR802_BV020_ParameterSet_SC_Status = 15168;

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_SC_StabilityIndicator Variable.
        /// </summary>
        public const uint PR802_BV020_ParameterSet_SC_StabilityIndicator = 15169;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the WeightScaleType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.WeightScaleType_Lock_InitLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.WeightScaleType_Lock_RenewLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.WeightScaleType_Lock_ExitLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.WeightScaleType_Lock_BreakLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.WeightScaleType_CPIdentifier_Lock_InitLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.WeightScaleType_CPIdentifier_Lock_RenewLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.WeightScaleType_CPIdentifier_Lock_ExitLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.WeightScaleType_CPIdentifier_Lock_BreakLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_MethodSet_Tare Method.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_MethodSet_Tare = new ExpandedNodeId(Opc.Ua.Ws.Methods.WeightScaleType_MethodSet_Tare, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_MethodSet_Zero Method.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_MethodSet_Zero = new ExpandedNodeId(Opc.Ua.Ws.Methods.WeightScaleType_MethodSet_Zero, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.MettlerToledoPR802_Lock_InitLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.MettlerToledoPR802_Lock_RenewLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.MettlerToledoPR802_Lock_ExitLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.MettlerToledoPR802_Lock_BreakLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.MettlerToledoPR802_CPIdentifier_Lock_InitLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.MettlerToledoPR802_CPIdentifier_Lock_RenewLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.MettlerToledoPR802_CPIdentifier_Lock_ExitLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.MettlerToledoPR802_CPIdentifier_Lock_BreakLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_Tare Method.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_MethodSet_Tare = new ExpandedNodeId(Opc.Ua.Ws.Methods.MettlerToledoPR802_MethodSet_Tare, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_Zero Method.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_MethodSet_Zero = new ExpandedNodeId(Opc.Ua.Ws.Methods.MettlerToledoPR802_MethodSet_Zero, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_Connect Method.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_MethodSet_COM_Connect = new ExpandedNodeId(Opc.Ua.Ws.Methods.MettlerToledoPR802_MethodSet_COM_Connect, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_IsConnected Method.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_MethodSet_COM_IsConnected = new ExpandedNodeId(Opc.Ua.Ws.Methods.MettlerToledoPR802_MethodSet_COM_IsConnected, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_SendMTSICSCommand Method.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_MethodSet_COM_SendMTSICSCommand = new ExpandedNodeId(Opc.Ua.Ws.Methods.MettlerToledoPR802_MethodSet_COM_SendMTSICSCommand, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_Disconect Method.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_MethodSet_COM_Disconect = new ExpandedNodeId(Opc.Ua.Ws.Methods.MettlerToledoPR802_MethodSet_COM_Disconect, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.PR802_BV020_Lock_InitLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.PR802_BV020_Lock_RenewLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.PR802_BV020_Lock_ExitLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.PR802_BV020_Lock_BreakLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.PR802_BV020_CPIdentifier_Lock_InitLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.PR802_BV020_CPIdentifier_Lock_RenewLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.PR802_BV020_CPIdentifier_Lock_ExitLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.PR802_BV020_CPIdentifier_Lock_BreakLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_MethodSet_Tare Method.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_MethodSet_Tare = new ExpandedNodeId(Opc.Ua.Ws.Methods.PR802_BV020_MethodSet_Tare, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_MethodSet_Zero Method.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_MethodSet_Zero = new ExpandedNodeId(Opc.Ua.Ws.Methods.PR802_BV020_MethodSet_Zero, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_MethodSet_COM_Connect Method.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_MethodSet_COM_Connect = new ExpandedNodeId(Opc.Ua.Ws.Methods.PR802_BV020_MethodSet_COM_Connect, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_MethodSet_COM_IsConnected Method.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_MethodSet_COM_IsConnected = new ExpandedNodeId(Opc.Ua.Ws.Methods.PR802_BV020_MethodSet_COM_IsConnected, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_MethodSet_COM_SendMTSICSCommand Method.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_MethodSet_COM_SendMTSICSCommand = new ExpandedNodeId(Opc.Ua.Ws.Methods.PR802_BV020_MethodSet_COM_SendMTSICSCommand, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_MethodSet_COM_Disconect Method.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_MethodSet_COM_Disconect = new ExpandedNodeId(Opc.Ua.Ws.Methods.PR802_BV020_MethodSet_COM_Disconect, Opc.Ua.Ws.Namespaces.OpcUaWs);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the WeightScaleType_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_ParameterSet = new ExpandedNodeId(Opc.Ua.Ws.Objects.WeightScaleType_ParameterSet, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_MethodSet = new ExpandedNodeId(Opc.Ua.Ws.Objects.WeightScaleType_MethodSet, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Ws.Objects.WeightScaleType_CPIdentifier_NetworkAddress, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_ParameterSet = new ExpandedNodeId(Opc.Ua.Ws.Objects.MettlerToledoPR802_ParameterSet, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_MethodSet = new ExpandedNodeId(Opc.Ua.Ws.Objects.MettlerToledoPR802_MethodSet, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Ws.Objects.MettlerToledoPR802_CPIdentifier_NetworkAddress, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020 Object.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020 = new ExpandedNodeId(Opc.Ua.Ws.Objects.PR802_BV020, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet Object.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_ParameterSet = new ExpandedNodeId(Opc.Ua.Ws.Objects.PR802_BV020_ParameterSet, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_MethodSet = new ExpandedNodeId(Opc.Ua.Ws.Objects.PR802_BV020_MethodSet, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Ws.Objects.PR802_BV020_CPIdentifier_NetworkAddress, Opc.Ua.Ws.Namespaces.OpcUaWs);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the WeightScaleType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType = new ExpandedNodeId(Opc.Ua.Ws.ObjectTypes.WeightScaleType, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802 ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802 = new ExpandedNodeId(Opc.Ua.Ws.ObjectTypes.MettlerToledoPR802, Opc.Ua.Ws.Namespaces.OpcUaWs);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the WeightScaleType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_Lock_Locked, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_Lock_LockingClient, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_Lock_LockingUser, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_Lock_RemainingLockTime, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_Lock_InitLock_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_Lock_InitLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_Lock_RenewLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_Lock_ExitLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_Lock_BreakLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_CPIdentifier_Lock_Locked, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_CPIdentifier_Lock_LockingClient, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_CPIdentifier_Lock_LockingUser, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_ParameterSet_weightScale Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_ParameterSet_weightScale = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_ParameterSet_weightScale, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_ParameterSet_weightScale_InstrumentRange Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_ParameterSet_weightScale_InstrumentRange = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_ParameterSet_weightScale_InstrumentRange, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_ParameterSet_weightScale_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_ParameterSet_weightScale_EURange = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_ParameterSet_weightScale_EURange, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the WeightScaleType_ParameterSet_weightScale_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId WeightScaleType_ParameterSet_weightScale_EngineeringUnits = new ExpandedNodeId(Opc.Ua.Ws.Variables.WeightScaleType_ParameterSet_weightScale_EngineeringUnits, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_Lock_Locked = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_Lock_Locked, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_Lock_LockingClient, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_Lock_LockingUser, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_Lock_RemainingLockTime, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_Lock_InitLock_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_Lock_InitLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_Lock_RenewLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_Lock_ExitLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_Lock_BreakLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_Manufacturer = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_Manufacturer, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_Model = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_Model, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_DeviceClass Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_DeviceClass = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_DeviceClass, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_SerialNumber = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_SerialNumber, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_CPIdentifier_Lock_Locked, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_CPIdentifier_Lock_LockingClient, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_CPIdentifier_Lock_LockingUser, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_weightScale_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_ParameterSet_weightScale_EngineeringUnits = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_ParameterSet_weightScale_EngineeringUnits, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_COM_SerialPort_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_ParameterSet_COM_SerialPort_Status = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_ParameterSet_COM_SerialPort_Status, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_StaticScale_Filler_01.WV_STABLE Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_ParameterSet_StaticScale_Filler_01.WV_STABLE = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_ParameterSet_StaticScale_Filler_01.WV_STABLE, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_StaticScale_Filler_01.WV Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_ParameterSet_StaticScale_Filler_01.WV = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_ParameterSet_StaticScale_Filler_01.WV, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_StaticScale_Filler_01.COMMAND_SI Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_ParameterSet_StaticScale_Filler_01.COMMAND_SI = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_ParameterSet_StaticScale_Filler_01.COMMAND_SI, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_StaticScale_Filler_02.WV_STABLE Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_ParameterSet_StaticScale_Filler_02.WV_STABLE = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_ParameterSet_StaticScale_Filler_02.WV_STABLE, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_StaticScale_Filler_02.WV Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_ParameterSet_StaticScale_Filler_02.WV = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_ParameterSet_StaticScale_Filler_02.WV, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_StaticScale_Filler_02.COMMAND_SI Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_ParameterSet_StaticScale_Filler_02.COMMAND_SI = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_ParameterSet_StaticScale_Filler_02.COMMAND_SI, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_StaticScale_Filler_03.WV_STABLE Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_ParameterSet_StaticScale_Filler_03.WV_STABLE = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_ParameterSet_StaticScale_Filler_03.WV_STABLE, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_StaticScale_Filler_03.WV Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_ParameterSet_StaticScale_Filler_03.WV = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_ParameterSet_StaticScale_Filler_03.WV, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_StaticScale_Filler_03.COMMAND_SI Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_ParameterSet_StaticScale_Filler_03.COMMAND_SI = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_ParameterSet_StaticScale_Filler_03.COMMAND_SI, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_SC_NetWeight Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_ParameterSet_SC_NetWeight = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_ParameterSet_SC_NetWeight, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_SC_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_ParameterSet_SC_Status = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_ParameterSet_SC_Status, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_ParameterSet_SC_StabilityIndicator Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_ParameterSet_SC_StabilityIndicator = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_ParameterSet_SC_StabilityIndicator, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_Connect_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_MethodSet_COM_Connect_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_MethodSet_COM_Connect_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_Connect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_MethodSet_COM_Connect_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_MethodSet_COM_Connect_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_IsConnected_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_MethodSet_COM_IsConnected_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_MethodSet_COM_IsConnected_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_SendMTSICSCommand_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_MethodSet_COM_SendMTSICSCommand_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_MethodSet_COM_SendMTSICSCommand_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_SendMTSICSCommand_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_MethodSet_COM_SendMTSICSCommand_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_MethodSet_COM_SendMTSICSCommand_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the MettlerToledoPR802_MethodSet_COM_Disconect_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MettlerToledoPR802_MethodSet_COM_Disconect_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.MettlerToledoPR802_MethodSet_COM_Disconect_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_Lock_Locked = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_Lock_Locked, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_Lock_LockingClient, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_Lock_LockingUser, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_Lock_RemainingLockTime, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_Lock_InitLock_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_Lock_InitLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_Lock_RenewLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_Lock_ExitLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_Lock_BreakLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_Manufacturer Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_Manufacturer = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_Manufacturer, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_Model Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_Model = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_Model, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_HardwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_HardwareRevision = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_HardwareRevision, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_SoftwareRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_SoftwareRevision = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_SoftwareRevision, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_DeviceRevision Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_DeviceRevision = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_DeviceRevision, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_DeviceManual Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_DeviceManual = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_DeviceManual, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_DeviceClass Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_DeviceClass = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_DeviceClass, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_SerialNumber Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_SerialNumber = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_SerialNumber, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_RevisionCounter Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_RevisionCounter = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_RevisionCounter, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_CPIdentifier_Lock_Locked, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_CPIdentifier_Lock_LockingClient, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_CPIdentifier_Lock_LockingUser, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_weightScale_EngineeringUnits Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_ParameterSet_weightScale_EngineeringUnits = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_ParameterSet_weightScale_EngineeringUnits, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_COM_SerialPort_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_ParameterSet_COM_SerialPort_Status = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_ParameterSet_COM_SerialPort_Status, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_StaticScale_Filler_01.WV_STABLE Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_ParameterSet_StaticScale_Filler_01.WV_STABLE = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_ParameterSet_StaticScale_Filler_01.WV_STABLE, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_StaticScale_Filler_01.WV Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_ParameterSet_StaticScale_Filler_01.WV = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_ParameterSet_StaticScale_Filler_01.WV, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_StaticScale_Filler_01.COMMAND_SI Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_ParameterSet_StaticScale_Filler_01.COMMAND_SI = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_ParameterSet_StaticScale_Filler_01.COMMAND_SI, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_StaticScale_Filler_02.WV_STABLE Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_ParameterSet_StaticScale_Filler_02.WV_STABLE = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_ParameterSet_StaticScale_Filler_02.WV_STABLE, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_StaticScale_Filler_02.WV Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_ParameterSet_StaticScale_Filler_02.WV = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_ParameterSet_StaticScale_Filler_02.WV, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_StaticScale_Filler_02.COMMAND_SI Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_ParameterSet_StaticScale_Filler_02.COMMAND_SI = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_ParameterSet_StaticScale_Filler_02.COMMAND_SI, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_StaticScale_Filler_03.WV_STABLE Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_ParameterSet_StaticScale_Filler_03.WV_STABLE = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_ParameterSet_StaticScale_Filler_03.WV_STABLE, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_StaticScale_Filler_03.WV Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_ParameterSet_StaticScale_Filler_03.WV = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_ParameterSet_StaticScale_Filler_03.WV, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_StaticScale_Filler_03.COMMAND_SI Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_ParameterSet_StaticScale_Filler_03.COMMAND_SI = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_ParameterSet_StaticScale_Filler_03.COMMAND_SI, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_SC_NetWeight Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_ParameterSet_SC_NetWeight = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_ParameterSet_SC_NetWeight, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_SC_Status Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_ParameterSet_SC_Status = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_ParameterSet_SC_Status, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the PR802_BV020_ParameterSet_SC_StabilityIndicator Variable.
        /// </summary>
        public static readonly ExpandedNodeId PR802_BV020_ParameterSet_SC_StabilityIndicator = new ExpandedNodeId(Opc.Ua.Ws.Variables.PR802_BV020_ParameterSet_SC_StabilityIndicator, Opc.Ua.Ws.Namespaces.OpcUaWs);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the MethodSet component.
        /// </summary>
        public const string MethodSet = "MethodSet";

        /// <summary>
        /// The BrowseName for the MettlerToledoPR802 component.
        /// </summary>
        public const string MettlerToledoPR802 = "MettlerToledoPR802";

        /// <summary>
        /// The BrowseName for the ParameterSet component.
        /// </summary>
        public const string ParameterSet = "ParameterSet";

        /// <summary>
        /// The BrowseName for the PR802_BV020 component.
        /// </summary>
        public const string PR802_BV020 = "PR802_BV020";

        /// <summary>
        /// The BrowseName for the WeightScaleType component.
        /// </summary>
        public const string WeightScaleType = "WeightScaleType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUaWs namespace (.NET code namespace is 'Opc.Ua.Ws').
        /// </summary>
        public const string OpcUaWs = "http://phi-ware.com/FEISTU/WS/";

        /// <summary>
        /// The URI for the OpcUaWsXsd namespace (.NET code namespace is 'Opc.Ua.Ws').
        /// </summary>
        public const string OpcUaWsXsd = "http://phi-ware.com/FEISTU/WS/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaDi namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDi = "http://opcfoundation.org/UA/DI/";

        /// <summary>
        /// The URI for the OpcUaDiXsd namespace (.NET code namespace is 'Opc.Ua.Di').
        /// </summary>
        public const string OpcUaDiXsd = "http://opcfoundation.org/UA/DI/Types.xsd";

        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";
    }
    #endregion
}