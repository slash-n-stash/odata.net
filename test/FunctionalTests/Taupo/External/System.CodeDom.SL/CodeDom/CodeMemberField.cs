﻿//---------------------------------------------------------------------
// <copyright file="CodeMemberField.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

namespace System.CodeDom {

    using System.Diagnostics;
    using System;
    using System.Collections;
    using System.Runtime.InteropServices;

    /// <devdoc>
    ///    <para>
    ///       Represents a class field member.
    ///    </para>
    /// </devdoc>
    [
        ClassInterface(ClassInterfaceType.None),
        ComVisible(true),
#if FRAMEWORK 
        //Serializable, 
#endif
]
    public class CodeMemberField : CodeTypeMember {
        private CodeTypeReference type;
        private CodeExpression initExpression;

        /// <devdoc>
        ///    <para>
        ///       Initializes a new <see cref='System.CodeDom.CodeMemberField'/>.
        ///    </para>
        /// </devdoc>
        public CodeMemberField() {
        }

        /// <devdoc>
        ///    <para>
        ///       Initializes a new <see cref='System.CodeDom.CodeMemberField'/> with the specified member field type and
        ///       name.
        ///    </para>
        /// </devdoc>
        public CodeMemberField(CodeTypeReference type, string name) {
            Type = type;
            Name = name;
        }

        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public CodeMemberField(string type, string name) {
            Type = new CodeTypeReference(type);
            Name = name;
        }

        /// <devdoc>
        ///    <para>[To be supplied.]</para>
        /// </devdoc>
        public CodeMemberField(Type type, string name) {
            Type = new CodeTypeReference(type);
            Name = name;
        }

        /// <devdoc>
        ///    <para>
        ///       Gets or sets the member field type.
        ///    </para>
        /// </devdoc>
        public CodeTypeReference Type {
            get {
                if (type == null) {
                    type = new CodeTypeReference("");
                }
                return type;
            }
            set {
                type = value;
            }
        }

        /// <devdoc>
        ///    <para>
        ///       Gets or sets the initialization expression for the member field.
        ///    </para>
        /// </devdoc>
        public CodeExpression InitExpression {
            get {
                return initExpression;
            }
            set {
                initExpression = value;
            }
        }
    }
}
