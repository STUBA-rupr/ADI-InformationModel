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
using Opc.Ua.Adi;
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
        /// The identifier for the ScaleDeviceType_Lock_InitLock Method.
        /// </summary>
        public const uint ScaleDeviceType_Lock_InitLock = 15015;

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_RenewLock Method.
        /// </summary>
        public const uint ScaleDeviceType_Lock_RenewLock = 15018;

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_ExitLock Method.
        /// </summary>
        public const uint ScaleDeviceType_Lock_ExitLock = 15020;

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_BreakLock Method.
        /// </summary>
        public const uint ScaleDeviceType_Lock_BreakLock = 15022;

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ScaleDeviceType_CPIdentifier_Lock_InitLock = 15050;

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ScaleDeviceType_CPIdentifier_Lock_RenewLock = 15053;

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ScaleDeviceType_CPIdentifier_Lock_ExitLock = 15055;

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ScaleDeviceType_CPIdentifier_Lock_BreakLock = 15057;

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_GetConfiguration Method.
        /// </summary>
        public const uint ScaleDeviceType_MethodSet_GetConfiguration = 15071;

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_SetConfiguration Method.
        /// </summary>
        public const uint ScaleDeviceType_MethodSet_SetConfiguration = 15073;

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_GetConfigDataDigest Method.
        /// </summary>
        public const uint ScaleDeviceType_MethodSet_GetConfigDataDigest = 15076;

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_CompareConfigDataDigest Method.
        /// </summary>
        public const uint ScaleDeviceType_MethodSet_CompareConfigDataDigest = 15078;

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_ResetAllChannels Method.
        /// </summary>
        public const uint ScaleDeviceType_MethodSet_ResetAllChannels = 15081;

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_StartAllChannels Method.
        /// </summary>
        public const uint ScaleDeviceType_MethodSet_StartAllChannels = 15082;

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_StopAllChannels Method.
        /// </summary>
        public const uint ScaleDeviceType_MethodSet_StopAllChannels = 15083;

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_AbortAllChannels Method.
        /// </summary>
        public const uint ScaleDeviceType_MethodSet_AbortAllChannels = 15084;

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_GotoOperating Method.
        /// </summary>
        public const uint ScaleDeviceType_MethodSet_GotoOperating = 15085;

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_GotoMaintenance Method.
        /// </summary>
        public const uint ScaleDeviceType_MethodSet_GotoMaintenance = 15086;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Open Method.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_Open = 15096;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Close Method.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_Close = 15099;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Read Method.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_Read = 15101;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Write Method.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_Write = 15104;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_GetPosition Method.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_GetPosition = 15106;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_SetPosition Method.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_SetPosition = 15109;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_InitLock Method.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_Lock_InitLock = 15143;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_RenewLock Method.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_Lock_RenewLock = 15146;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_ExitLock Method.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_Lock_ExitLock = 15148;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_BreakLock Method.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_Lock_BreakLock = 15150;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_GotoOperating Method.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_MethodSet_GotoOperating = 15152;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_GotoMaintenance Method.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_MethodSet_GotoMaintenance = 15153;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition Method.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition = 15154;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_Reset Method.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_MethodSet_Reset = 15156;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_Start Method.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_MethodSet_Start = 15157;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_Stop Method.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_MethodSet_Stop = 15158;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_Hold Method.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_MethodSet_Hold = 15159;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_Unhold Method.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_MethodSet_Unhold = 15160;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_Suspend Method.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_MethodSet_Suspend = 15161;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_Unsuspend Method.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_MethodSet_Unsuspend = 15162;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_Abort Method.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_MethodSet_Abort = 15163;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_Clear Method.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_MethodSet_Clear = 15164;
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
        /// The identifier for the ScaleDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public const uint ScaleDeviceType_CPIdentifier_NetworkAddress = 15059;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet Object.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_MethodSet = 15134;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Configuration Object.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_Configuration = 15177;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Status Object.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_Status = 15179;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine Object.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ChannelStateMachine = 15181;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine Object.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine = 15195;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine Object.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine = 15209;

        /// <summary>
        /// The identifier for the ScaleDeviceType_AccessorySlotIdentifier_SupportedTypes Object.
        /// </summary>
        public const uint ScaleDeviceType_AccessorySlotIdentifier_SupportedTypes = 15252;

        /// <summary>
        /// The identifier for the ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine Object.
        /// </summary>
        public const uint ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine = 15255;
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
        /// The identifier for the ScaleDeviceType ObjectType.
        /// </summary>
        public const uint ScaleDeviceType = 15001;
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
        /// The identifier for the ScaleDeviceType_Lock_Locked Variable.
        /// </summary>
        public const uint ScaleDeviceType_Lock_Locked = 15011;

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public const uint ScaleDeviceType_Lock_LockingClient = 15012;

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public const uint ScaleDeviceType_Lock_LockingUser = 15013;

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ScaleDeviceType_Lock_RemainingLockTime = 15014;

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_Lock_InitLock_InputArguments = 15016;

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_Lock_InitLock_OutputArguments = 15017;

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_Lock_RenewLock_OutputArguments = 15019;

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_Lock_ExitLock_OutputArguments = 15021;

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_Lock_BreakLock_OutputArguments = 15023;

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint ScaleDeviceType_CPIdentifier_Lock_Locked = 15046;

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ScaleDeviceType_CPIdentifier_Lock_LockingClient = 15047;

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ScaleDeviceType_CPIdentifier_Lock_LockingUser = 15048;

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ScaleDeviceType_CPIdentifier_Lock_RemainingLockTime = 15049;

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_CPIdentifier_Lock_InitLock_InputArguments = 15051;

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = 15052;

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = 15054;

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = 15056;

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = 15058;

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_GetConfiguration_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_MethodSet_GetConfiguration_OutputArguments = 15072;

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_SetConfiguration_InputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_MethodSet_SetConfiguration_InputArguments = 15074;

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_SetConfiguration_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_MethodSet_SetConfiguration_OutputArguments = 15075;

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_GetConfigDataDigest_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_MethodSet_GetConfigDataDigest_OutputArguments = 15077;

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_CompareConfigDataDigest_InputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_MethodSet_CompareConfigDataDigest_InputArguments = 15079;

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_CompareConfigDataDigest_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_MethodSet_CompareConfigDataDigest_OutputArguments = 15080;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_DiagnosticStatus = 15087;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Size Variable.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_Size = 15091;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Writable Variable.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_Writable = 15092;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_UserWritable Variable.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_UserWritable = 15093;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_OpenCount Variable.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_OpenCount = 15094;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Open_InputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_Open_InputArguments = 15097;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Open_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_Open_OutputArguments = 15098;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Close_InputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_Close_InputArguments = 15100;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Read_InputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_Read_InputArguments = 15102;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Read_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_Read_OutputArguments = 15103;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Write_InputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_Write_InputArguments = 15105;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_GetPosition_InputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_GetPosition_InputArguments = 15107;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_GetPosition_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_GetPosition_OutputArguments = 15108;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_SetPosition_InputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_ParameterSet_ConfigData_SetPosition_InputArguments = 15110;

        /// <summary>
        /// The identifier for the ScaleDeviceType_AnalyserStateMachine_CurrentState Variable.
        /// </summary>
        public const uint ScaleDeviceType_AnalyserStateMachine_CurrentState = 15118;

        /// <summary>
        /// The identifier for the ScaleDeviceType_AnalyserStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint ScaleDeviceType_AnalyserStateMachine_CurrentState_Id = 15119;

        /// <summary>
        /// The identifier for the ScaleDeviceType_AnalyserStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint ScaleDeviceType_AnalyserStateMachine_LastTransition_Id = 15124;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_Locked Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_Lock_Locked = 15139;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_Lock_LockingClient = 15140;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_Lock_LockingUser = 15141;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_Lock_RemainingLockTime = 15142;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_Lock_InitLock_InputArguments = 15144;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_Lock_InitLock_OutputArguments = 15145;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_Lock_RenewLock_OutputArguments = 15147;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_Lock_ExitLock_OutputArguments = 15149;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_Lock_BreakLock_OutputArguments = 15151;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition_InputArguments Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition_InputArguments = 15155;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ParameterSet_IsEnabled Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ParameterSet_IsEnabled = 15168;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ParameterSet_DiagnosticStatus = 15171;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ParameterSet_ActiveStream Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ParameterSet_ActiveStream = 15174;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_CurrentState Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_CurrentState = 15182;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_CurrentState_Id = 15183;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LastTransition_Id = 15188;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState = 15196;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id = 15197;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id = 15202;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState = 15210;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id = 15211;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id = 15216;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState = 15224;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id = 15225;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id = 15230;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState = 15238;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id = 15239;

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id = 15244;

        /// <summary>
        /// The identifier for the ScaleDeviceType_AccessorySlotIdentifier_IsHotSwappable Variable.
        /// </summary>
        public const uint ScaleDeviceType_AccessorySlotIdentifier_IsHotSwappable = 15253;

        /// <summary>
        /// The identifier for the ScaleDeviceType_AccessorySlotIdentifier_IsEnabled Variable.
        /// </summary>
        public const uint ScaleDeviceType_AccessorySlotIdentifier_IsEnabled = 15254;

        /// <summary>
        /// The identifier for the ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState Variable.
        /// </summary>
        public const uint ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState = 15256;

        /// <summary>
        /// The identifier for the ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState_Id Variable.
        /// </summary>
        public const uint ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState_Id = 15257;

        /// <summary>
        /// The identifier for the ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine_LastTransition_Id Variable.
        /// </summary>
        public const uint ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine_LastTransition_Id = 15262;
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
        /// The identifier for the ScaleDeviceType_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_Lock_InitLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_Lock_RenewLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_Lock_ExitLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_Lock_BreakLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_CPIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_CPIdentifier_Lock_InitLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_CPIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_CPIdentifier_Lock_RenewLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_CPIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_CPIdentifier_Lock_ExitLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_CPIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_CPIdentifier_Lock_BreakLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_GetConfiguration Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_MethodSet_GetConfiguration = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_MethodSet_GetConfiguration, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_SetConfiguration Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_MethodSet_SetConfiguration = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_MethodSet_SetConfiguration, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_GetConfigDataDigest Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_MethodSet_GetConfigDataDigest = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_MethodSet_GetConfigDataDigest, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_CompareConfigDataDigest Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_MethodSet_CompareConfigDataDigest = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_MethodSet_CompareConfigDataDigest, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_ResetAllChannels Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_MethodSet_ResetAllChannels = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_MethodSet_ResetAllChannels, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_StartAllChannels Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_MethodSet_StartAllChannels = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_MethodSet_StartAllChannels, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_StopAllChannels Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_MethodSet_StopAllChannels = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_MethodSet_StopAllChannels, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_AbortAllChannels Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_MethodSet_AbortAllChannels = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_MethodSet_AbortAllChannels, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_GotoOperating Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_MethodSet_GotoOperating = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_MethodSet_GotoOperating, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_GotoMaintenance Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_MethodSet_GotoMaintenance = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_MethodSet_GotoMaintenance, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Open Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_Open = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ParameterSet_ConfigData_Open, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Close Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_Close = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ParameterSet_ConfigData_Close, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Read Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_Read = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ParameterSet_ConfigData_Read, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Write Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_Write = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ParameterSet_ConfigData_Write, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_GetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_GetPosition = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ParameterSet_ConfigData_GetPosition, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_SetPosition Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_SetPosition = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ParameterSet_ConfigData_SetPosition, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_InitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_Lock_InitLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ChannelIdentifier_Lock_InitLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_RenewLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_Lock_RenewLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ChannelIdentifier_Lock_RenewLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_ExitLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_Lock_ExitLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ChannelIdentifier_Lock_ExitLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_BreakLock Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_Lock_BreakLock = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ChannelIdentifier_Lock_BreakLock, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_GotoOperating Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_MethodSet_GotoOperating = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ChannelIdentifier_MethodSet_GotoOperating, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_GotoMaintenance Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_MethodSet_GotoMaintenance = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ChannelIdentifier_MethodSet_GotoMaintenance, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_Reset Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_MethodSet_Reset = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ChannelIdentifier_MethodSet_Reset, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_Start Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_MethodSet_Start = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ChannelIdentifier_MethodSet_Start, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_Stop Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_MethodSet_Stop = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ChannelIdentifier_MethodSet_Stop, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_Hold Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_MethodSet_Hold = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ChannelIdentifier_MethodSet_Hold, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_Unhold Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_MethodSet_Unhold = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ChannelIdentifier_MethodSet_Unhold, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_Suspend Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_MethodSet_Suspend = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ChannelIdentifier_MethodSet_Suspend, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_Unsuspend Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_MethodSet_Unsuspend = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ChannelIdentifier_MethodSet_Unsuspend, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_Abort Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_MethodSet_Abort = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ChannelIdentifier_MethodSet_Abort, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_Clear Method.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_MethodSet_Clear = new ExpandedNodeId(Opc.Ua.Ws.Methods.ScaleDeviceType_ChannelIdentifier_MethodSet_Clear, Opc.Ua.Ws.Namespaces.OpcUaWs);
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
        /// The identifier for the ScaleDeviceType_CPIdentifier_NetworkAddress Object.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_CPIdentifier_NetworkAddress = new ExpandedNodeId(Opc.Ua.Ws.Objects.ScaleDeviceType_CPIdentifier_NetworkAddress, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet Object.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_MethodSet = new ExpandedNodeId(Opc.Ua.Ws.Objects.ScaleDeviceType_ChannelIdentifier_MethodSet, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Configuration Object.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_Configuration = new ExpandedNodeId(Opc.Ua.Ws.Objects.ScaleDeviceType_ChannelIdentifier_Configuration, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Status Object.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_Status = new ExpandedNodeId(Opc.Ua.Ws.Objects.ScaleDeviceType_ChannelIdentifier_Status, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ChannelStateMachine = new ExpandedNodeId(Opc.Ua.Ws.Objects.ScaleDeviceType_ChannelIdentifier_ChannelStateMachine, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine = new ExpandedNodeId(Opc.Ua.Ws.Objects.ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine = new ExpandedNodeId(Opc.Ua.Ws.Objects.ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_AccessorySlotIdentifier_SupportedTypes Object.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_AccessorySlotIdentifier_SupportedTypes = new ExpandedNodeId(Opc.Ua.Ws.Objects.ScaleDeviceType_AccessorySlotIdentifier_SupportedTypes, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine Object.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine = new ExpandedNodeId(Opc.Ua.Ws.Objects.ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine, Opc.Ua.Ws.Namespaces.OpcUaWs);
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
        /// The identifier for the ScaleDeviceType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType = new ExpandedNodeId(Opc.Ua.Ws.ObjectTypes.ScaleDeviceType, Opc.Ua.Ws.Namespaces.OpcUaWs);
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
        /// The identifier for the ScaleDeviceType_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_Lock_Locked = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_Lock_Locked, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_Lock_LockingClient, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_Lock_LockingUser, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_Lock_RemainingLockTime, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_Lock_InitLock_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_Lock_InitLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_Lock_RenewLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_Lock_ExitLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_Lock_BreakLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_CPIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_CPIdentifier_Lock_Locked, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_CPIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_CPIdentifier_Lock_LockingClient, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_CPIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_CPIdentifier_Lock_LockingUser, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_CPIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_CPIdentifier_Lock_RemainingLockTime, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_CPIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_CPIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_CPIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_CPIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_CPIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_CPIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_CPIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_GetConfiguration_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_MethodSet_GetConfiguration_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_MethodSet_GetConfiguration_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_SetConfiguration_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_MethodSet_SetConfiguration_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_MethodSet_SetConfiguration_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_SetConfiguration_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_MethodSet_SetConfiguration_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_MethodSet_SetConfiguration_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_GetConfigDataDigest_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_MethodSet_GetConfigDataDigest_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_MethodSet_GetConfigDataDigest_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_CompareConfigDataDigest_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_MethodSet_CompareConfigDataDigest_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_MethodSet_CompareConfigDataDigest_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_MethodSet_CompareConfigDataDigest_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_MethodSet_CompareConfigDataDigest_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_MethodSet_CompareConfigDataDigest_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_DiagnosticStatus = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ParameterSet_DiagnosticStatus, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Size Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_Size = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ParameterSet_ConfigData_Size, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Writable Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_Writable = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ParameterSet_ConfigData_Writable, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_UserWritable Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_UserWritable = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ParameterSet_ConfigData_UserWritable, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_OpenCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_OpenCount = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ParameterSet_ConfigData_OpenCount, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Open_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_Open_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ParameterSet_ConfigData_Open_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Open_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_Open_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ParameterSet_ConfigData_Open_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Close_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_Close_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ParameterSet_ConfigData_Close_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Read_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_Read_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ParameterSet_ConfigData_Read_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Read_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_Read_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ParameterSet_ConfigData_Read_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_Write_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_Write_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ParameterSet_ConfigData_Write_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_GetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_GetPosition_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ParameterSet_ConfigData_GetPosition_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_GetPosition_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_GetPosition_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ParameterSet_ConfigData_GetPosition_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ParameterSet_ConfigData_SetPosition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ParameterSet_ConfigData_SetPosition_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ParameterSet_ConfigData_SetPosition_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_AnalyserStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_AnalyserStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_AnalyserStateMachine_CurrentState, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_AnalyserStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_AnalyserStateMachine_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_AnalyserStateMachine_CurrentState_Id, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_AnalyserStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_AnalyserStateMachine_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_AnalyserStateMachine_LastTransition_Id, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_Locked Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_Lock_Locked = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_Lock_Locked, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_LockingClient Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_Lock_LockingClient = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_Lock_LockingClient, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_LockingUser Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_Lock_LockingUser = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_Lock_LockingUser, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_RemainingLockTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_Lock_RemainingLockTime = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_Lock_RemainingLockTime, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_InitLock_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_Lock_InitLock_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_Lock_InitLock_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_InitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_Lock_InitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_Lock_InitLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_RenewLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_Lock_RenewLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_Lock_RenewLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_ExitLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_Lock_ExitLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_Lock_ExitLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_Lock_BreakLock_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_Lock_BreakLock_OutputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_Lock_BreakLock_OutputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition_InputArguments = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_MethodSet_StartSingleAcquisition_InputArguments, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ParameterSet_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ParameterSet_IsEnabled = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_ParameterSet_IsEnabled, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ParameterSet_DiagnosticStatus Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ParameterSet_DiagnosticStatus = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_ParameterSet_DiagnosticStatus, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ParameterSet_ActiveStream Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ParameterSet_ActiveStream = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_ParameterSet_ActiveStream, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_CurrentState, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_CurrentState_Id, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LastTransition_Id, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_CurrentState_Id, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_LastTransition_Id, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_CurrentState_Id, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_OperatingSubStateMachine_OperatingExecuteSubStateMachine_LastTransition_Id, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_CurrentState_Id, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_LocalSubStateMachine_LastTransition_Id, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_CurrentState_Id, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_ChannelIdentifier_ChannelStateMachine_MaintenanceSubStateMachine_LastTransition_Id, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_AccessorySlotIdentifier_IsHotSwappable Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_AccessorySlotIdentifier_IsHotSwappable = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_AccessorySlotIdentifier_IsHotSwappable, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_AccessorySlotIdentifier_IsEnabled Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_AccessorySlotIdentifier_IsEnabled = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_AccessorySlotIdentifier_IsEnabled, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState_Id = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine_CurrentState_Id, Opc.Ua.Ws.Namespaces.OpcUaWs);

        /// <summary>
        /// The identifier for the ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine_LastTransition_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine_LastTransition_Id = new ExpandedNodeId(Opc.Ua.Ws.Variables.ScaleDeviceType_AccessorySlotIdentifier_AccessorySlotStateMachine_LastTransition_Id, Opc.Ua.Ws.Namespaces.OpcUaWs);
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
        /// The BrowseName for the ScaleDeviceType component.
        /// </summary>
        public const string ScaleDeviceType = "ScaleDeviceType";
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
        public const string OpcUaWs = "http://opcfoundation.org/FEISTU/WS/";

        /// <summary>
        /// The URI for the OpcUaWsXsd namespace (.NET code namespace is 'Opc.Ua.Ws').
        /// </summary>
        public const string OpcUaWsXsd = "http://opcfoundation.org/FEISTU/WS/Types.xsd";

        /// <summary>
        /// The URI for the OpcUaAdi namespace (.NET code namespace is 'Opc.Ua.Adi').
        /// </summary>
        public const string OpcUaAdi = "http://opcfoundation.org/UA/ADI/";

        /// <summary>
        /// The URI for the OpcUaAdiXsd namespace (.NET code namespace is 'Opc.Ua.Adi').
        /// </summary>
        public const string OpcUaAdiXsd = "http://opcfoundation.org/UA/ADI/Types.xsd";

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