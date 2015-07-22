﻿using Pytocs.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pytocs.Translate
{
    public class ExpNameDiscovery : IExpVisitor
    {
        private SymbolTable syms;

        public ExpNameDiscovery(SymbolTable syms)
        {
            this.syms = syms;
        }

        public void VisitApplication(Application appl)
        {
            throw new NotImplementedException();
        }

        public void VisitArrayRef(ArrayRef arrayRef)
        {
            throw new NotImplementedException();
        }

        public void VisitAssignExp(AssignExp assignExp)
        {
            throw new NotImplementedException();
        }

        public void VisitBinExp(BinExp bin)
        {
            throw new NotImplementedException();
        }

        public void VisitBooleanLiteral(BooleanLiteral b)
        {
            throw new NotImplementedException();
        }

        public void VisitCompFor(CompFor f)
        {
            throw new NotImplementedException();
        }

        public void VisitCompIf(CompIf i)
        {
            throw new NotImplementedException();
        }

        public void VisitDottedName(DottedName d)
        {
            throw new NotImplementedException();
        }

        public void VisitEllipsis(Ellipsis e)
        {
            throw new NotImplementedException();
        }

        public void VisitExpList(ExpList list)
        {
            throw new NotImplementedException();
        }

        public void VisitFieldAccess(AttributeAccess acc)
        {
            throw new NotImplementedException();
        }

        public void VisitIdentifier(Identifier id)
        {
            syms.Reference(id.Name);
        }

        public void VisitImaginaryLiteral(ImaginaryLiteral im)
        {
            throw new NotImplementedException();
        }

        public void VisitIntLiteral(IntLiteral s)
        {
            throw new NotImplementedException();
        }

        public void VisitLambda(Lambda lambda)
        {
            throw new NotImplementedException();
        }

        public void VisitListComprehension(ListComprehension lc)
        {
            throw new NotImplementedException();
        }

        public void VisitList(PyList l)
        {
            throw new NotImplementedException();
        }

        public void VisitLongLiteral(LongLiteral l)
        {
            throw new NotImplementedException();
        }

        public void VisitNoneExp()
        {
            throw new NotImplementedException();
        }

        public void VisitRealLiteral(RealLiteral r)
        {
            throw new NotImplementedException();
        }

        public void VisitSet(PySet setDisplay)
        {
            throw new NotImplementedException();
        }

        public void VisitStarExp(StarExp e)
        {
            throw new NotImplementedException();
        }

        public void VisitBytes(Bytes b)
        {
            throw new NotImplementedException();
        }

        public void VisitStr(Str s)
        {
            throw new NotImplementedException();
        }

        public void VisitTest(Test tuple)
        {
            throw new NotImplementedException();
        }

        public void VisitTuple(PyTuple tuple)
        {
            throw new NotImplementedException();
        }

        public void VisitUnary(UnaryExp u)
        {
            throw new NotImplementedException();
        }

        public void VisitYieldExp(YieldExp yieldExp)
        {
            throw new NotImplementedException();
        }

        public void VisitYieldFromExp(YieldFromExp yieldExp)
        {
            throw new NotImplementedException();
        }

        public void VisitAliasedExp(AliasedExp aliasedExp)
        {
            throw new NotImplementedException();
        }

        public void VisitSetComprehension(SetComprehension setComprehension)
        {
            throw new NotImplementedException();
        }


        public void VisitSlice(Slice slice)
        {
            throw new NotImplementedException();
        }


        public void VisitDictComprehension(DictComprehension dc)
        {
            throw new NotImplementedException();
        }


        public void VisitDictInitializer(DictInitializer di)
        {
            throw new NotImplementedException();
        }
    }
}