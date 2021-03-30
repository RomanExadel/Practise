using Practise.Structures;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Practise
{
    struct ProcessNameEqualityComparer : IEqualityComparer<Process>
    {
        public bool Equals(Process process1, Process process2)
        {
            return string.Equals(process1.Name, process2.Name);
        }

        public int GetHashCode([DisallowNull] Process obj)
        {
            return HashCode.Combine(obj.Name);
        }
    }
}
