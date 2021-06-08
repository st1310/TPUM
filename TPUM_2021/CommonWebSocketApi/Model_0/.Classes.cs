/* ========================================================================
 * Copyright (c) 2005-2016 The OPC Foundation, Inc. All rights reserved.
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
using Opc.Ua;

namespace 
{
    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the CustomerS ObjectType.
        /// </summary>
        public const uint CustomerS = 3;

        /// <summary>
        /// The identifier for the InvoiceS ObjectType.
        /// </summary>
        public const uint InvoiceS = 7;

        /// <summary>
        /// The identifier for the ProductS ObjectType.
        /// </summary>
        public const uint ProductS = 13;
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
        /// The identifier for the CustomerS_Id Variable.
        /// </summary>
        public const uint CustomerS_Id = 4;

        /// <summary>
        /// The identifier for the CustomerS_Name Variable.
        /// </summary>
        public const uint CustomerS_Name = 5;

        /// <summary>
        /// The identifier for the CustomerS_Funds Variable.
        /// </summary>
        public const uint CustomerS_Funds = 6;

        /// <summary>
        /// The identifier for the InvoiceS_Id Variable.
        /// </summary>
        public const uint InvoiceS_Id = 8;

        /// <summary>
        /// The identifier for the InvoiceS_ProductId Variable.
        /// </summary>
        public const uint InvoiceS_ProductId = 9;

        /// <summary>
        /// The identifier for the InvoiceS_CustomerId Variable.
        /// </summary>
        public const uint InvoiceS_CustomerId = 10;

        /// <summary>
        /// The identifier for the InvoiceS_Date Variable.
        /// </summary>
        public const uint InvoiceS_Date = 11;

        /// <summary>
        /// The identifier for the InvoiceS_Price Variable.
        /// </summary>
        public const uint InvoiceS_Price = 12;

        /// <summary>
        /// The identifier for the ProductS_Id Variable.
        /// </summary>
        public const uint ProductS_Id = 14;

        /// <summary>
        /// The identifier for the ProductS_Name Variable.
        /// </summary>
        public const uint ProductS_Name = 15;

        /// <summary>
        /// The identifier for the ProductS_Price Variable.
        /// </summary>
        public const uint ProductS_Price = 16;

        /// <summary>
        /// The identifier for the ProductS_CustomerId Variable.
        /// </summary>
        public const uint ProductS_CustomerId = 17;
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
        /// The identifier for the CustomerS ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId CustomerS = new ExpandedNodeId(Opc.Ua.ObjectTypes.CustomerS, Opc.Ua.Namespaces.OpcUa);

        /// <summary>
        /// The identifier for the InvoiceS ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId InvoiceS = new ExpandedNodeId(Opc.Ua.ObjectTypes.InvoiceS, Opc.Ua.Namespaces.OpcUa);

        /// <summary>
        /// The identifier for the ProductS ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ProductS = new ExpandedNodeId(Opc.Ua.ObjectTypes.ProductS, Opc.Ua.Namespaces.OpcUa);
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
        /// The identifier for the CustomerS_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId CustomerS_Id = new ExpandedNodeId(Opc.Ua.Variables.CustomerS_Id, Opc.Ua.Namespaces.OpcUa);

        /// <summary>
        /// The identifier for the CustomerS_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId CustomerS_Name = new ExpandedNodeId(Opc.Ua.Variables.CustomerS_Name, Opc.Ua.Namespaces.OpcUa);

        /// <summary>
        /// The identifier for the CustomerS_Funds Variable.
        /// </summary>
        public static readonly ExpandedNodeId CustomerS_Funds = new ExpandedNodeId(Opc.Ua.Variables.CustomerS_Funds, Opc.Ua.Namespaces.OpcUa);

        /// <summary>
        /// The identifier for the InvoiceS_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId InvoiceS_Id = new ExpandedNodeId(Opc.Ua.Variables.InvoiceS_Id, Opc.Ua.Namespaces.OpcUa);

        /// <summary>
        /// The identifier for the InvoiceS_ProductId Variable.
        /// </summary>
        public static readonly ExpandedNodeId InvoiceS_ProductId = new ExpandedNodeId(Opc.Ua.Variables.InvoiceS_ProductId, Opc.Ua.Namespaces.OpcUa);

        /// <summary>
        /// The identifier for the InvoiceS_CustomerId Variable.
        /// </summary>
        public static readonly ExpandedNodeId InvoiceS_CustomerId = new ExpandedNodeId(Opc.Ua.Variables.InvoiceS_CustomerId, Opc.Ua.Namespaces.OpcUa);

        /// <summary>
        /// The identifier for the InvoiceS_Date Variable.
        /// </summary>
        public static readonly ExpandedNodeId InvoiceS_Date = new ExpandedNodeId(Opc.Ua.Variables.InvoiceS_Date, Opc.Ua.Namespaces.OpcUa);

        /// <summary>
        /// The identifier for the InvoiceS_Price Variable.
        /// </summary>
        public static readonly ExpandedNodeId InvoiceS_Price = new ExpandedNodeId(Opc.Ua.Variables.InvoiceS_Price, Opc.Ua.Namespaces.OpcUa);

        /// <summary>
        /// The identifier for the ProductS_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProductS_Id = new ExpandedNodeId(Opc.Ua.Variables.ProductS_Id, Opc.Ua.Namespaces.OpcUa);

        /// <summary>
        /// The identifier for the ProductS_Name Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProductS_Name = new ExpandedNodeId(Opc.Ua.Variables.ProductS_Name, Opc.Ua.Namespaces.OpcUa);

        /// <summary>
        /// The identifier for the ProductS_Price Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProductS_Price = new ExpandedNodeId(Opc.Ua.Variables.ProductS_Price, Opc.Ua.Namespaces.OpcUa);

        /// <summary>
        /// The identifier for the ProductS_CustomerId Variable.
        /// </summary>
        public static readonly ExpandedNodeId ProductS_CustomerId = new ExpandedNodeId(Opc.Ua.Variables.ProductS_CustomerId, Opc.Ua.Namespaces.OpcUa);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the cas namespace (.NET code namespace is '').
        /// </summary>
        public const string cas = "http://cas.eu/UA/CommServer/";

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