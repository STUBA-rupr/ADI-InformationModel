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
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua.Adi;
using Opc.Ua;

namespace Opc.Ua.Ws
{
    #region ScaleDeviceState Class
    #if (!OPCUA_EXCLUDE_ScaleDeviceState)
    /// <summary>
    /// Stores an instance of the ScaleDeviceType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ScaleDeviceState : AnalyserDeviceState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ScaleDeviceState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Opc.Ua.Ws.ObjectTypes.ScaleDeviceType, Opc.Ua.Ws.Namespaces.OpcUaWs, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AgAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvRkVJU1RVL1dTLyAAAABodHRwOi8vb3BjZm91" +
           "bmRhdGlvbi5vcmcvVUEvQURJL/////+EYIACAQAAAAEAFwAAAFNjYWxlRGV2aWNlVHlwZUluc3RhbmNl" +
           "AQGZOgEBmTqZOgAAAf////8OAAAAJGCACgEAAAD//wkAAABNZXRob2RTZXQBAZw6AwAAAAAUAAAARmxh" +
           "dCBsaXN0IG9mIE1ldGhvZHMALwA6nDoAAP////8KAAAABGGCCgQAAAACABAAAABHZXRDb25maWd1cmF0" +
           "aW9uAQHfOgAvAQLjJN86AAABAf////8BAAAAF2CpCgIAAAAAAA8AAABPdXRwdXRBcmd1bWVudHMBAeA6" +
           "AC4AROA6AACWAQAAAAEAKgEBGQAAAAoAAABDb25maWdEYXRhAA//////AAAAAAABACgBAQAAAAEAAAAA" +
           "AAAAAQH/////AAAAAARhggoEAAAAAgAQAAAAU2V0Q29uZmlndXJhdGlvbgEB4ToALwEC5SThOgAAAQH/" +
           "////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVudHMBAeI6AC4AROI6AACWAQAAAAEAKgEBGQAA" +
           "AAoAAABDb25maWdEYXRhAA//////AAAAAAABACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAA" +
           "AAAPAAAAT3V0cHV0QXJndW1lbnRzAQHjOgAuAETjOgAAlgEAAAABACoBAR8AAAAQAAAAQ29uZmlnRGF0" +
           "YURpZ2VzdAAM/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB/////wAAAAAEYYIKBAAAAAIAEwAAAEdl" +
           "dENvbmZpZ0RhdGFEaWdlc3QBAeQ6AC8BAugk5DoAAAEB/////wEAAAAXYKkKAgAAAAAADwAAAE91dHB1" +
           "dEFyZ3VtZW50cwEB5ToALgBE5ToAAJYBAAAAAQAqAQEfAAAAEAAAAENvbmZpZ0RhdGFEaWdlc3QADP//" +
           "//8AAAAAAAEAKAEBAAAAAQAAAAAAAAABAf////8AAAAABGGCCgQAAAACABcAAABDb21wYXJlQ29uZmln" +
           "RGF0YURpZ2VzdAEB5joALwEC6iTmOgAAAQH/////AgAAABdgqQoCAAAAAAAOAAAASW5wdXRBcmd1bWVu" +
           "dHMBAec6AC4AROc6AACWAQAAAAEAKgEBHwAAABAAAABDb25maWdEYXRhRGlnZXN0AAz/////AAAAAAAB" +
           "ACgBAQAAAAEAAAAAAAAAAQH/////AAAAABdgqQoCAAAAAAAPAAAAT3V0cHV0QXJndW1lbnRzAQHoOgAu" +
           "AEToOgAAlgEAAAABACoBARYAAAAHAAAASXNFcXVhbAAB/////wAAAAAAAQAoAQEAAAABAAAAAAAAAAEB" +
           "/////wAAAAAkYYIKBAAAAAIAEAAAAFJlc2V0QWxsQ2hhbm5lbHMBAek6AwAAAAA8AAAAUmVzZXQgYWxs" +
           "IEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8BAu0k6ToA" +
           "AAEB/////wAAAAAkYYIKBAAAAAIAEAAAAFN0YXJ0QWxsQ2hhbm5lbHMBAeo6AwAAAAA8AAAAU3RhcnQg" +
           "YWxsIEFuYWx5c2VyQ2hhbm5lbHMgYmVsb25naW5nIHRvIHRoaXMgQW5hbHlzZXJEZXZpY2UuAC8BAu4k" +
           "6joAAAEB/////wAAAAAkYYIKBAAAAAIADwAAAFN0b3BBbGxDaGFubmVscwEB6zoDAAAAADsAAABTdG9w" +
           "IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5c2VyRGV2aWNlLgAvAQLv" +
           "JOs6AAABAf////8AAAAAJGGCCgQAAAACABAAAABBYm9ydEFsbENoYW5uZWxzAQHsOgMAAAAAPAAAAEFi" +
           "b3J0IGFsbCBBbmFseXNlckNoYW5uZWxzIGJlbG9uZ2luZyB0byB0aGlzIEFuYWx5c2VyRGV2aWNlLgAv" +
           "AQLwJOw6AAABAf////8AAAAAJGGCCgQAAAACAA0AAABHb3RvT3BlcmF0aW5nAQHtOgMAAAAAjQAAAEFu" +
           "YWx5c2VyRGV2aWNlU3RhdGVNYWNoaW5lIHRvIGdvIHRvIE9wZXJhdGluZyBzdGF0ZSwgZm9yY2luZyBh" +
           "bGwgQW5hbHlzZXJDaGFubmVscyB0byBsZWF2ZSB0aGUgU2xhdmVNb2RlIHN0YXRlIGFuZCBnbyB0byB0" +
           "aGUgT3BlcmF0aW5nIHN0YXRlLgAvAQLxJO06AAABAf////8AAAAAJGGCCgQAAAACAA8AAABHb3RvTWFp" +
           "bnRlbmFuY2UBAe46AwAAAABnAAAAQW5hbHlzZXJEZXZpY2VTdGF0ZU1hY2hpbmUgdG8gZ28gdG8gTWFp" +
           "bnRlbmFuY2Ugc3RhdGUsIGZvcmNpbmcgYWxsIEFuYWx5c2VyQ2hhbm5lbHMgdG8gU2xhdmVNb2RlIHN0" +
           "YXRlLgAvAQLyJO46AAABAf////8AAAAAJGCACgEAAAD//w4AAABJZGVudGlmaWNhdGlvbgEBoDoDAAAA" +
           "AEYAAABVc2VkIHRvIG9yZ2FuaXplIHBhcmFtZXRlcnMgZm9yIGlkZW50aWZpY2F0aW9uIG9mIHRoaXMg" +
           "VG9wb2xvZ3lFbGVtZW50AC8C///tAwAAoDoAAAMAAAAAIwAC//9zFwAAACMAAv//dBcAAAAjAAL//3EX" +
           "AAAAAAAANWCJCgIAAAD//wwAAABNYW51ZmFjdHVyZXIBAbA6AwAAAAAwAAAATmFtZSBvZiB0aGUgY29t" +
           "cGFueSB0aGF0IG1hbnVmYWN0dXJlZCB0aGUgZGV2aWNlAC4ARLA6AAAAFf////8BAf////8AAAAANWCJ" +
           "CgIAAAD//wUAAABNb2RlbAEBsjoDAAAAABgAAABNb2RlbCBuYW1lIG9mIHRoZSBkZXZpY2UALgBEsjoA" +
           "AAAV/////wEB/////wAAAAA1YIkKAgAAAP//EAAAAEhhcmR3YXJlUmV2aXNpb24BAbM6AwAAAAAsAAAA" +
           "UmV2aXNpb24gbGV2ZWwgb2YgdGhlIGhhcmR3YXJlIG9mIHRoZSBkZXZpY2UALgBEszoAAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAP//EAAAAFNvZnR3YXJlUmV2aXNpb24BAbQ6AwAAAAA1AAAAUmV2aXNpb24g" +
           "bGV2ZWwgb2YgdGhlIHNvZnR3YXJlL2Zpcm13YXJlIG9mIHRoZSBkZXZpY2UALgBEtDoAAAAM/////wEB" +
           "/////wAAAAA1YIkKAgAAAP//DgAAAERldmljZVJldmlzaW9uAQG1OgMAAAAAJAAAAE92ZXJhbGwgcmV2" +
           "aXNpb24gbGV2ZWwgb2YgdGhlIGRldmljZQAuAES1OgAAAAz/////AQH/////AAAAADVgiQoCAAAA//8M" +
           "AAAARGV2aWNlTWFudWFsAQG3OgMAAAAAWgAAAEFkZHJlc3MgKHBhdGhuYW1lIGluIHRoZSBmaWxlIHN5" +
           "c3RlbSBvciBhIFVSTCB8IFdlYiBhZGRyZXNzKSBvZiB1c2VyIG1hbnVhbCBmb3IgdGhlIGRldmljZQAu" +
           "AES3OgAAAAz/////AQH/////AAAAADVgiQoCAAAA//8MAAAAU2VyaWFsTnVtYmVyAQG5OgMAAAAATQAA" +
           "AElkZW50aWZpZXIgdGhhdCB1bmlxdWVseSBpZGVudGlmaWVzLCB3aXRoaW4gYSBtYW51ZmFjdHVyZXIs" +
           "IGEgZGV2aWNlIGluc3RhbmNlAC4ARLk6AAAADP////8BAf////8AAAAANWCJCgIAAAD//w8AAABSZXZp" +
           "c2lvbkNvdW50ZXIBAbs6AwAAAABpAAAAQW4gaW5jcmVtZW50YWwgY291bnRlciBpbmRpY2F0aW5nIHRo" +
           "ZSBudW1iZXIgb2YgdGltZXMgdGhlIHN0YXRpYyBkYXRhIHdpdGhpbiB0aGUgRGV2aWNlIGhhcyBiZWVu" +
           "IG1vZGlmaWVkAC4ARLs6AAAABv////8BAf////8AAAAABGCACgEAAAACAA0AAABDb25maWd1cmF0aW9u" +
           "AQEHOwAvAv//7QMAAAc7AAABAAAAACMAAQHyOgAAAAAEYIAKAQAAAAIABgAAAFN0YXR1cwEBCTsALwL/" +
           "/+0DAAAJOwAAAQAAAAAjAAEB7zoAAAAABGCACgEAAAACAA8AAABGYWN0b3J5U2V0dGluZ3MBAQs7AC8C" +
           "///tAwAACzsAAP////8AAAAABGCACgEAAAACABQAAABBbmFseXNlclN0YXRlTWFjaGluZQEBDTsALwEC" +
           "6gMNOwAA/////wEAAAAVYIkKAgAAAAAADAAAAEN1cnJlbnRTdGF0ZQEBDjsALwEAyAoOOwAAABX/////" +
           "AQH/////AQAAABVgiQoCAAAAAAACAAAASWQBAQ87AC4ARA87AAAAEf////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion
}