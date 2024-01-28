using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace BenchmarksDotNetEight.Loop
{
    public static class LoopOperations
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void OptimizedUnsafeSpanWhileLoop(Span<byte> input)
        {
            int len = input.Length;
            int idx = 0;

            // Get reference to the start of the span
            ref byte start = ref MemoryMarshal.GetReference(input);

            // Unroll the loop to reduce branching and improve performance
            int unrolledEnd = len - 128;
            while (idx < unrolledEnd)
            {
                byte value0   = Unsafe.Add(ref start, idx      );
                byte value1   = Unsafe.Add(ref start, idx + 1  );
                byte value2   = Unsafe.Add(ref start, idx + 2  );
                byte value3   = Unsafe.Add(ref start, idx + 3  );
                byte value4   = Unsafe.Add(ref start, idx + 4  );
                byte value5   = Unsafe.Add(ref start, idx + 5  );
                byte value6   = Unsafe.Add(ref start, idx + 6  );
                byte value7   = Unsafe.Add(ref start, idx + 7  );
                byte value8   = Unsafe.Add(ref start, idx + 8  );
                byte value9   = Unsafe.Add(ref start, idx + 9  );
                byte value10  = Unsafe.Add(ref start, idx + 10 );
                byte value11  = Unsafe.Add(ref start, idx + 11 );
                byte value12  = Unsafe.Add(ref start, idx + 12 );
                byte value13  = Unsafe.Add(ref start, idx + 13 );
                byte value14  = Unsafe.Add(ref start, idx + 14 );
                byte value15  = Unsafe.Add(ref start, idx + 15 );
                byte value16  = Unsafe.Add(ref start, idx + 16 );
                byte value17  = Unsafe.Add(ref start, idx + 17 );
                byte value18  = Unsafe.Add(ref start, idx + 18 );
                byte value19  = Unsafe.Add(ref start, idx + 19 );
                byte value20  = Unsafe.Add(ref start, idx + 20 );
                byte value21  = Unsafe.Add(ref start, idx + 21 );
                byte value22  = Unsafe.Add(ref start, idx + 22 );
                byte value23  = Unsafe.Add(ref start, idx + 23 );
                byte value24  = Unsafe.Add(ref start, idx + 24 );
                byte value25  = Unsafe.Add(ref start, idx + 25 );
                byte value26  = Unsafe.Add(ref start, idx + 26 );
                byte value27  = Unsafe.Add(ref start, idx + 27 );
                byte value28  = Unsafe.Add(ref start, idx + 28 );
                byte value29  = Unsafe.Add(ref start, idx + 29 );
                byte value30  = Unsafe.Add(ref start, idx + 30 );
                byte value31  = Unsafe.Add(ref start, idx + 31 );
                byte value32  = Unsafe.Add(ref start, idx + 32 );
                byte value33  = Unsafe.Add(ref start, idx + 33 );
                byte value34  = Unsafe.Add(ref start, idx + 34 );
                byte value35  = Unsafe.Add(ref start, idx + 35 );
                byte value36  = Unsafe.Add(ref start, idx + 36 );
                byte value37  = Unsafe.Add(ref start, idx + 37 );
                byte value38  = Unsafe.Add(ref start, idx + 38 );
                byte value39  = Unsafe.Add(ref start, idx + 39 );
                byte value40  = Unsafe.Add(ref start, idx + 40 );
                byte value41  = Unsafe.Add(ref start, idx + 41 );
                byte value42  = Unsafe.Add(ref start, idx + 42 );
                byte value43  = Unsafe.Add(ref start, idx + 43 );
                byte value44  = Unsafe.Add(ref start, idx + 44 );
                byte value45  = Unsafe.Add(ref start, idx + 45 );
                byte value46  = Unsafe.Add(ref start, idx + 46 );
                byte value47  = Unsafe.Add(ref start, idx + 47 );
                byte value48  = Unsafe.Add(ref start, idx + 48 );
                byte value49  = Unsafe.Add(ref start, idx + 49 );
                byte value50  = Unsafe.Add(ref start, idx + 50 );
                byte value51  = Unsafe.Add(ref start, idx + 51 );
                byte value52  = Unsafe.Add(ref start, idx + 52 );
                byte value53  = Unsafe.Add(ref start, idx + 53 );
                byte value54  = Unsafe.Add(ref start, idx + 54 );
                byte value55  = Unsafe.Add(ref start, idx + 55 );
                byte value56  = Unsafe.Add(ref start, idx + 56 );
                byte value57  = Unsafe.Add(ref start, idx + 57 );
                byte value58  = Unsafe.Add(ref start, idx + 58 );
                byte value59  = Unsafe.Add(ref start, idx + 59 );
                byte value60  = Unsafe.Add(ref start, idx + 60 );
                byte value61  = Unsafe.Add(ref start, idx + 61 );
                byte value62  = Unsafe.Add(ref start, idx + 62 );
                byte value63  = Unsafe.Add(ref start, idx + 63 );
                byte value64  = Unsafe.Add(ref start, idx + 64 );
                byte value65  = Unsafe.Add(ref start, idx + 65 );
                byte value66  = Unsafe.Add(ref start, idx + 66 );
                byte value67  = Unsafe.Add(ref start, idx + 67 );
                byte value68  = Unsafe.Add(ref start, idx + 68 );
                byte value69  = Unsafe.Add(ref start, idx + 69 );
                byte value70  = Unsafe.Add(ref start, idx + 70 );
                byte value71  = Unsafe.Add(ref start, idx + 71 );
                byte value72  = Unsafe.Add(ref start, idx + 72 );
                byte value73  = Unsafe.Add(ref start, idx + 73 );
                byte value74  = Unsafe.Add(ref start, idx + 74 );
                byte value75  = Unsafe.Add(ref start, idx + 75 );
                byte value76  = Unsafe.Add(ref start, idx + 76 );
                byte value77  = Unsafe.Add(ref start, idx + 77 );
                byte value78  = Unsafe.Add(ref start, idx + 78 );
                byte value79  = Unsafe.Add(ref start, idx + 79 );
                byte value80  = Unsafe.Add(ref start, idx + 80 );
                byte value81  = Unsafe.Add(ref start, idx + 81 );
                byte value82  = Unsafe.Add(ref start, idx + 82 );
                byte value83  = Unsafe.Add(ref start, idx + 83 );
                byte value84  = Unsafe.Add(ref start, idx + 84 );
                byte value85  = Unsafe.Add(ref start, idx + 85 );
                byte value86  = Unsafe.Add(ref start, idx + 86 );
                byte value87  = Unsafe.Add(ref start, idx + 87 );
                byte value88  = Unsafe.Add(ref start, idx + 88 );
                byte value89  = Unsafe.Add(ref start, idx + 89 );
                byte value90  = Unsafe.Add(ref start, idx + 90 );
                byte value91  = Unsafe.Add(ref start, idx + 91 );
                byte value92  = Unsafe.Add(ref start, idx + 92 );
                byte value93  = Unsafe.Add(ref start, idx + 93 );
                byte value94  = Unsafe.Add(ref start, idx + 94 );
                byte value95  = Unsafe.Add(ref start, idx + 95 );
                byte value96  = Unsafe.Add(ref start, idx + 96 );
                byte value97  = Unsafe.Add(ref start, idx + 97 );
                byte value98  = Unsafe.Add(ref start, idx + 98 );
                byte value99  = Unsafe.Add(ref start, idx + 99 );
                byte value100 = Unsafe.Add(ref start, idx + 100);
                byte value101 = Unsafe.Add(ref start, idx + 101);
                byte value102 = Unsafe.Add(ref start, idx + 102);
                byte value103 = Unsafe.Add(ref start, idx + 103);
                byte value104 = Unsafe.Add(ref start, idx + 104);
                byte value105 = Unsafe.Add(ref start, idx + 105);
                byte value106 = Unsafe.Add(ref start, idx + 106);
                byte value107 = Unsafe.Add(ref start, idx + 107);
                byte value108 = Unsafe.Add(ref start, idx + 108);
                byte value109 = Unsafe.Add(ref start, idx + 109);
                byte value110 = Unsafe.Add(ref start, idx + 110);
                byte value111 = Unsafe.Add(ref start, idx + 111);
                byte value112 = Unsafe.Add(ref start, idx + 112);
                byte value113 = Unsafe.Add(ref start, idx + 113);
                byte value114 = Unsafe.Add(ref start, idx + 114);
                byte value115 = Unsafe.Add(ref start, idx + 115);
                byte value116 = Unsafe.Add(ref start, idx + 116);
                byte value117 = Unsafe.Add(ref start, idx + 117);
                byte value118 = Unsafe.Add(ref start, idx + 118);
                byte value119 = Unsafe.Add(ref start, idx + 119);
                byte value120 = Unsafe.Add(ref start, idx + 120);
                byte value121 = Unsafe.Add(ref start, idx + 121);
                byte value122 = Unsafe.Add(ref start, idx + 122);
                byte value123 = Unsafe.Add(ref start, idx + 123);
                byte value124 = Unsafe.Add(ref start, idx + 124);
                byte value125 = Unsafe.Add(ref start, idx + 125);
                byte value126 = Unsafe.Add(ref start, idx + 126);
                byte value127 = Unsafe.Add(ref start, idx + 127);

                idx += 128;
            }

            // Process the remaining elements (if any) with a regular loop
            for (; idx < len; idx++)
            {
                byte value = Unsafe.Add(ref start, idx);
                // Perform your operations here
            }
        }
    }
}
