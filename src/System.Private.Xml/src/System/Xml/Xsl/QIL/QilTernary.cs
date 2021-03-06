// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Xml.Xsl.Qil
{
    /// <summary>
    /// View over a Qil operator having three children.
    /// </summary>
    /// <remarks>
    /// Don't construct QIL nodes directly; instead, use the <see cref="QilFactory">QilFactory</see>.
    /// </remarks>
    internal class QilTernary : QilNode
    {
        private QilNode _left, _center, _right;


        //-----------------------------------------------
        // Constructor
        //-----------------------------------------------

        /// <summary>
        /// Construct a new node
        /// </summary>
        public QilTernary(QilNodeType nodeType, QilNode left, QilNode center, QilNode right) : base(nodeType)
        {
            _left = left;
            _center = center;
            _right = right;
        }


        //-----------------------------------------------
        // IList<QilNode> methods -- override
        //-----------------------------------------------

        public override int Count
        {
            get { return 3; }
        }

        public override QilNode this[int index]
        {
            get
            {
                return index switch
                {
                    0 => _left,
                    1 => _center,
                    2 => _right,
                    _ => throw new IndexOutOfRangeException(),
                };
            }
            set
            {
                switch (index)
                {
                    case 0: _left = value; break;
                    case 1: _center = value; break;
                    case 2: _right = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }


        //-----------------------------------------------
        // QilTernary methods
        //-----------------------------------------------

        public QilNode Left
        {
            get { return _left; }
            set { _left = value; }
        }

        public QilNode Center
        {
            get { return _center; }
            set { _center = value; }
        }

        public QilNode Right
        {
            get { return _right; }
            set { _right = value; }
        }
    }
}
