/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
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

namespace OPCUAdependencies
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
        public const uint CustomerS = 15001;

        /// <summary>
        /// The identifier for the InvoiceS ObjectType.
        /// </summary>
        public const uint InvoiceS = 15005;

        /// <summary>
        /// The identifier for the ProductS ObjectType.
        /// </summary>
        public const uint ProductS = 15011;
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
        public const uint CustomerS_Id = 15002;

        /// <summary>
        /// The identifier for the CustomerS_Name Variable.
        /// </summary>
        public const uint CustomerS_Name = 15003;

        /// <summary>
        /// The identifier for the CustomerS_Funds Variable.
        /// </summary>
        public const uint CustomerS_Funds = 15004;

        /// <summary>
        /// The identifier for the InvoiceS_Id Variable.
        /// </summary>
        public const uint InvoiceS_Id = 15006;

        /// <summary>
        /// The identifier for the InvoiceS_ProductId Variable.
        /// </summary>
        public const uint InvoiceS_ProductId = 15007;

        /// <summary>
        /// The identifier for the InvoiceS_CustomerId Variable.
        /// </summary>
        public const uint InvoiceS_CustomerId = 15008;

        /// <summary>
        /// The identifier for the InvoiceS_Date Variable.
        /// </summary>
        public const uint InvoiceS_Date = 15009;

        /// <summary>
        /// The identifier for the InvoiceS_Price Variable.
        /// </summary>
        public const uint InvoiceS_Price = 15010;

        /// <summary>
        /// The identifier for the ProductS_Id Variable.
        /// </summary>
        public const uint ProductS_Id = 15012;

        /// <summary>
        /// The identifier for the ProductS_Name Variable.
        /// </summary>
        public const uint ProductS_Name = 15013;

        /// <summary>
        /// The identifier for the ProductS_Price Variable.
        /// </summary>
        public const uint ProductS_Price = 15014;

        /// <summary>
        /// The identifier for the ProductS_CustomerId Variable.
        /// </summary>
        public const uint ProductS_CustomerId = 15015;
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
        public static readonly NodeId CustomerS = new NodeId(OPCUAdependencies.ObjectTypes.CustomerS);

        /// <summary>
        /// The identifier for the InvoiceS ObjectType.
        /// </summary>
        public static readonly NodeId InvoiceS = new NodeId(OPCUAdependencies.ObjectTypes.InvoiceS);

        /// <summary>
        /// The identifier for the ProductS ObjectType.
        /// </summary>
        public static readonly NodeId ProductS = new NodeId(OPCUAdependencies.ObjectTypes.ProductS);
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
        public static readonly NodeId CustomerS_Id = new NodeId(OPCUAdependencies.Variables.CustomerS_Id);

        /// <summary>
        /// The identifier for the CustomerS_Name Variable.
        /// </summary>
        public static readonly NodeId CustomerS_Name = new NodeId(OPCUAdependencies.Variables.CustomerS_Name);

        /// <summary>
        /// The identifier for the CustomerS_Funds Variable.
        /// </summary>
        public static readonly NodeId CustomerS_Funds = new NodeId(OPCUAdependencies.Variables.CustomerS_Funds);

        /// <summary>
        /// The identifier for the InvoiceS_Id Variable.
        /// </summary>
        public static readonly NodeId InvoiceS_Id = new NodeId(OPCUAdependencies.Variables.InvoiceS_Id);

        /// <summary>
        /// The identifier for the InvoiceS_ProductId Variable.
        /// </summary>
        public static readonly NodeId InvoiceS_ProductId = new NodeId(OPCUAdependencies.Variables.InvoiceS_ProductId);

        /// <summary>
        /// The identifier for the InvoiceS_CustomerId Variable.
        /// </summary>
        public static readonly NodeId InvoiceS_CustomerId = new NodeId(OPCUAdependencies.Variables.InvoiceS_CustomerId);

        /// <summary>
        /// The identifier for the InvoiceS_Date Variable.
        /// </summary>
        public static readonly NodeId InvoiceS_Date = new NodeId(OPCUAdependencies.Variables.InvoiceS_Date);

        /// <summary>
        /// The identifier for the InvoiceS_Price Variable.
        /// </summary>
        public static readonly NodeId InvoiceS_Price = new NodeId(OPCUAdependencies.Variables.InvoiceS_Price);

        /// <summary>
        /// The identifier for the ProductS_Id Variable.
        /// </summary>
        public static readonly NodeId ProductS_Id = new NodeId(OPCUAdependencies.Variables.ProductS_Id);

        /// <summary>
        /// The identifier for the ProductS_Name Variable.
        /// </summary>
        public static readonly NodeId ProductS_Name = new NodeId(OPCUAdependencies.Variables.ProductS_Name);

        /// <summary>
        /// The identifier for the ProductS_Price Variable.
        /// </summary>
        public static readonly NodeId ProductS_Price = new NodeId(OPCUAdependencies.Variables.ProductS_Price);

        /// <summary>
        /// The identifier for the ProductS_CustomerId Variable.
        /// </summary>
        public static readonly NodeId ProductS_CustomerId = new NodeId(OPCUAdependencies.Variables.ProductS_CustomerId);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the CustomerId component.
        /// </summary>
        public const string CustomerId = "CustomerId";

        /// <summary>
        /// The BrowseName for the CustomerS component.
        /// </summary>
        public const string CustomerS = "SProduct";

        /// <summary>
        /// The BrowseName for the Date component.
        /// </summary>
        public const string Date = "Date";

        /// <summary>
        /// The BrowseName for the Funds component.
        /// </summary>
        public const string Funds = "Funds";

        /// <summary>
        /// The BrowseName for the Id component.
        /// </summary>
        public const string Id = "Id";

        /// <summary>
        /// The BrowseName for the InvoiceS component.
        /// </summary>
        public const string InvoiceS = "InvoiceS";

        /// <summary>
        /// The BrowseName for the Name component.
        /// </summary>
        public const string Name = "Name";

        /// <summary>
        /// The BrowseName for the Price component.
        /// </summary>
        public const string Price = "Price";

        /// <summary>
        /// The BrowseName for the ProductId component.
        /// </summary>
        public const string ProductId = "ProductId";

        /// <summary>
        /// The BrowseName for the ProductS component.
        /// </summary>
        public const string ProductS = "InvoiceS";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the ua namespace (.NET code namespace is 'OPCUAdependencies').
        /// </summary>
        public const string ua = "http://opcfoundation.org/UA/";
    }
    #endregion

    #region CustomerSState Class
#if (!OPCUA_EXCLUDE_CustomerSState)
    /// <summary>
    /// Stores an instance of the CustomerS ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class CustomerSState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public CustomerSState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OPCUAdependencies.ObjectTypes.CustomerS, OPCUAdependencies.Namespaces.ua, namespaceUris);
        }

#if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
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
           "//////////8EYIACAQAAAAAAEQAAAEN1c3RvbWVyU0luc3RhbmNlAQCZOgEAmTqZOgAA/////wAAAAA=";
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

    #region InvoiceSState Class
#if (!OPCUA_EXCLUDE_InvoiceSState)
    /// <summary>
    /// Stores an instance of the InvoiceS ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class InvoiceSState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public InvoiceSState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OPCUAdependencies.ObjectTypes.InvoiceS, OPCUAdependencies.Namespaces.ua, namespaceUris);
        }

#if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
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
           "//////////8EYIACAQAAAAAAEAAAAEludm9pY2VTSW5zdGFuY2UBAJ06AQCdOp06AAD/////AAAAAA==";
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

    #region ProductSState Class
#if (!OPCUA_EXCLUDE_ProductSState)
    /// <summary>
    /// Stores an instance of the ProductS ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProductSState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ProductSState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(OPCUAdependencies.ObjectTypes.ProductS, OPCUAdependencies.Namespaces.ua, namespaceUris);
        }

#if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
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
           "//////////8EYIACAQAAAAAAEAAAAFByb2R1Y3RTSW5zdGFuY2UBAKM6AQCjOqM6AAD/////AAAAAA==";
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