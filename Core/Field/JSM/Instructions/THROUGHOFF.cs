﻿using System;


namespace OpenVIII.Fields.Scripts.Instructions
{
    internal sealed class THROUGHOFF : JsmInstruction
    {
        public THROUGHOFF()
        {
        }

        public THROUGHOFF(Int32 parameter, IStack<IJsmExpression> stack)
            : this()
        {
        }

        public override String ToString()
        {
            return $"{nameof(THROUGHOFF)}()";
        }
    }
}