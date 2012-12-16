using System;
using System.Collections.Generic;

namespace GrEmit.StackMutators
{
    internal class LdstrStackMutator : StackMutator
    {
        public override void Mutate(GroboIL il, ILInstructionParameter parameter, ref Stack<Type> stack)
        {
            stack.Push(typeof(string));
        }
    }
}