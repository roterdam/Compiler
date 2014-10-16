﻿namespace Compiler.ControlFlowGraph
{
    public enum Opcode
    {
        LEA,
        MOV,
        SUB,
        CMP,
        ADD,
        IMUL,
        XOR,

        CMOVE,
        CMOVNE,
        CMOVL,
        CMOVLE,
        CMOVG,
        CMOVGE,

        MOVD,
        MOVSD,
        ADDSD,
        SUBSD,
        MULSD,
        DIVSD
    }
}
