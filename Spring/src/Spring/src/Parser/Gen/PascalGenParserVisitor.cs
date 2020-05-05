using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node;
using JetBrains.ReSharper.Psi.TreeBuilder;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Gen
{
    public class PascalGenParserVisitor : PascalBaseParserVisitor
    {
        public PascalGenParserVisitor(PsiBuilder psiBuilder) : base(psiBuilder)
        {
        }

        public override object VisitActualParameter(GPascalParser.ActualParameterContext context)
        {
            VisitType(context, PascalNodeTypes.ActualParameter);
            return null;
        }

        public override object VisitAdditiveoperator(GPascalParser.AdditiveoperatorContext context)
        {
            VisitType(context, PascalNodeTypes.Additiveoperator);
            return null;
        }

        public override object VisitArrayType(GPascalParser.ArrayTypeContext context)
        {
            VisitType(context, PascalNodeTypes.ArrayType);
            return null;
        }

        public override object VisitAssignmentStatement(GPascalParser.AssignmentStatementContext context)
        {
            VisitType(context, PascalNodeTypes.AssignmentStatement);
            return null;
        }

        public override object VisitBaseType(GPascalParser.BaseTypeContext context)
        {
            VisitType(context, PascalNodeTypes.BaseType);
            return null;
        }

        public override object VisitBlock(GPascalParser.BlockContext context)
        {
            VisitType(context, PascalNodeTypes.Block);
            return null;
        }

        public override object VisitBool(GPascalParser.BoolContext context)
        {
            VisitType(context, PascalNodeTypes.Bool);
            return null;
        }

        public override object VisitCaseListElement(GPascalParser.CaseListElementContext context)
        {
            VisitType(context, PascalNodeTypes.CaseListElement);
            return null;
        }

        public override object VisitCaseStatement(GPascalParser.CaseStatementContext context)
        {
            VisitType(context, PascalNodeTypes.CaseStatement);
            return null;
        }

        public override object VisitComponentType(GPascalParser.ComponentTypeContext context)
        {
            VisitType(context, PascalNodeTypes.ComponentType);
            return null;
        }

        public override object VisitCompoundStatement(GPascalParser.CompoundStatementContext context)
        {
            VisitType(context, PascalNodeTypes.CompoundStatement);
            return null;
        }

        public override object VisitConditionalStatement(GPascalParser.ConditionalStatementContext context)
        {
            VisitType(context, PascalNodeTypes.ConditionalStatement);
            return null;
        }

        public override object VisitConstList(GPascalParser.ConstListContext context)
        {
            VisitType(context, PascalNodeTypes.ConstList);
            return null;
        }

        public override object VisitConstant(GPascalParser.ConstantContext context)
        {
            VisitType(context, PascalNodeTypes.Constant);
            return null;
        }

        public override object VisitConstantChr(GPascalParser.ConstantChrContext context)
        {
            VisitType(context, PascalNodeTypes.ConstantChr);
            return null;
        }

        public override object VisitConstantDefinition(GPascalParser.ConstantDefinitionContext context)
        {
            VisitType(context, PascalNodeTypes.ConstantDefinition);
            return null;
        }

        public override object VisitConstantDefinitionPart(GPascalParser.ConstantDefinitionPartContext context)
        {
            VisitType(context, PascalNodeTypes.ConstantDefinitionPart);
            return null;
        }

        public override object VisitElement(GPascalParser.ElementContext context)
        {
            VisitType(context, PascalNodeTypes.Element);
            return null;
        }

        public override object VisitElementList(GPascalParser.ElementListContext context)
        {
            VisitType(context, PascalNodeTypes.ElementList);
            return null;
        }

        public override object VisitEmpty(GPascalParser.EmptyContext context)
        {
            VisitType(context, PascalNodeTypes.Empty);
            return null;
        }

        public override object VisitEmptyStatement(GPascalParser.EmptyStatementContext context)
        {
            VisitType(context, PascalNodeTypes.EmptyStatement);
            return null;
        }

        public override object VisitExpression(GPascalParser.ExpressionContext context)
        {
            VisitType(context, PascalNodeTypes.Expression);
            return null;
        }

        public override object VisitFactor(GPascalParser.FactorContext context)
        {
            VisitType(context, PascalNodeTypes.Factor);
            return null;
        }

        public override object VisitFieldList(GPascalParser.FieldListContext context)
        {
            VisitType(context, PascalNodeTypes.FieldList);
            return null;
        }

        public override object VisitFileType(GPascalParser.FileTypeContext context)
        {
            VisitType(context, PascalNodeTypes.FileType);
            return null;
        }

        public override object VisitFinalValue(GPascalParser.FinalValueContext context)
        {
            VisitType(context, PascalNodeTypes.FinalValue);
            return null;
        }

        public override object VisitFixedPart(GPascalParser.FixedPartContext context)
        {
            VisitType(context, PascalNodeTypes.FixedPart);
            return null;
        }

        public override object VisitForList(GPascalParser.ForListContext context)
        {
            VisitType(context, PascalNodeTypes.ForList);
            return null;
        }

        public override object VisitForStatement(GPascalParser.ForStatementContext context)
        {
            VisitType(context, PascalNodeTypes.ForStatement);
            return null;
        }

        public override object VisitFormalParameterList(GPascalParser.FormalParameterListContext context)
        {
            VisitType(context, PascalNodeTypes.FormalParameterList);
            return null;
        }

        public override object VisitFormalParameterSection(GPascalParser.FormalParameterSectionContext context)
        {
            VisitType(context, PascalNodeTypes.FormalParameterSection);
            return null;
        }

        public override object VisitFunctionDeclaration(GPascalParser.FunctionDeclarationContext context)
        {
            VisitType(context, PascalNodeTypes.FunctionDeclaration);
            return null;
        }

        public override object VisitFunctionDesignator(GPascalParser.FunctionDesignatorContext context)
        {
            VisitType(context, PascalNodeTypes.FunctionDesignator);
            return null;
        }

        public override object VisitFunctionType(GPascalParser.FunctionTypeContext context)
        {
            VisitType(context, PascalNodeTypes.FunctionType);
            return null;
        }

        public override object VisitGotoStatement(GPascalParser.GotoStatementContext context)
        {
            VisitType(context, PascalNodeTypes.GotoStatement);
            return null;
        }

        public override object VisitIdentifier(GPascalParser.IdentifierContext context)
        {
            VisitType(context, PascalNodeTypes.Identifier);
            return null;
        }

        public override object VisitIdentifierList(GPascalParser.IdentifierListContext context)
        {
            VisitType(context, PascalNodeTypes.IdentifierList);
            return null;
        }

        public override object VisitIfStatement(GPascalParser.IfStatementContext context)
        {
            VisitType(context, PascalNodeTypes.IfStatement);
            return null;
        }

        public override object VisitIndexType(GPascalParser.IndexTypeContext context)
        {
            VisitType(context, PascalNodeTypes.IndexType);
            return null;
        }

        public override object VisitInitialValue(GPascalParser.InitialValueContext context)
        {
            VisitType(context, PascalNodeTypes.InitialValue);
            return null;
        }

        public override object VisitLabel(GPascalParser.LabelContext context)
        {
            VisitType(context, PascalNodeTypes.Label);
            return null;
        }

        public override object VisitLabelDeclarationPart(GPascalParser.LabelDeclarationPartContext context)
        {
            VisitType(context, PascalNodeTypes.LabelDeclarationPart);
            return null;
        }

        public override object VisitMultiplicativeoperator(GPascalParser.MultiplicativeoperatorContext context)
        {
            VisitType(context, PascalNodeTypes.Multiplicativeoperator);
            return null;
        }

        public override object VisitParameterGroup(GPascalParser.ParameterGroupContext context)
        {
            VisitType(context, PascalNodeTypes.ParameterGroup);
            return null;
        }

        public override object VisitParameterList(GPascalParser.ParameterListContext context)
        {
            VisitType(context, PascalNodeTypes.ParameterList);
            return null;
        }

        public override object VisitParameterwidth(GPascalParser.ParameterwidthContext context)
        {
            VisitType(context, PascalNodeTypes.Parameterwidth);
            return null;
        }

        public override object VisitPointerType(GPascalParser.PointerTypeContext context)
        {
            VisitType(context, PascalNodeTypes.PointerType);
            return null;
        }

        public override object VisitProcedureAndFunctionDeclarationPart(GPascalParser.ProcedureAndFunctionDeclarationPartContext context)
        {
            VisitType(context, PascalNodeTypes.ProcedureAndFunctionDeclarationPart);
            return null;
        }

        public override object VisitProcedureDeclaration(GPascalParser.ProcedureDeclarationContext context)
        {
            VisitType(context, PascalNodeTypes.ProcedureDeclaration);
            return null;
        }

        public override object VisitProcedureOrFunctionDeclaration(GPascalParser.ProcedureOrFunctionDeclarationContext context)
        {
            VisitType(context, PascalNodeTypes.ProcedureOrFunctionDeclaration);
            return null;
        }

        public override object VisitProcedureStatement(GPascalParser.ProcedureStatementContext context)
        {
            VisitType(context, PascalNodeTypes.ProcedureStatement);
            return null;
        }

        public override object VisitProcedureType(GPascalParser.ProcedureTypeContext context)
        {
            VisitType(context, PascalNodeTypes.ProcedureType);
            return null;
        }

        public override object VisitProgram(GPascalParser.ProgramContext context)
        {
            VisitType(context, PascalNodeTypes.Program);
            return null;
        }

        public override object VisitProgramHeading(GPascalParser.ProgramHeadingContext context)
        {
            VisitType(context, PascalNodeTypes.ProgramHeading);
            return null;
        }

        public override object VisitRecordSection(GPascalParser.RecordSectionContext context)
        {
            VisitType(context, PascalNodeTypes.RecordSection);
            return null;
        }

        public override object VisitRecordType(GPascalParser.RecordTypeContext context)
        {
            VisitType(context, PascalNodeTypes.RecordType);
            return null;
        }

        public override object VisitRecordVariableList(GPascalParser.RecordVariableListContext context)
        {
            VisitType(context, PascalNodeTypes.RecordVariableList);
            return null;
        }

        public override object VisitRelationaloperator(GPascalParser.RelationaloperatorContext context)
        {
            VisitType(context, PascalNodeTypes.Relationaloperator);
            return null;
        }

        public override object VisitRepeatStatement(GPascalParser.RepeatStatementContext context)
        {
            VisitType(context, PascalNodeTypes.RepeatStatement);
            return null;
        }

        public override object VisitRepetetiveStatement(GPascalParser.RepetetiveStatementContext context)
        {
            VisitType(context, PascalNodeTypes.RepetetiveStatement);
            return null;
        }

        public override object VisitResultType(GPascalParser.ResultTypeContext context)
        {
            VisitType(context, PascalNodeTypes.ResultType);
            return null;
        }

        public override object VisitScalarType(GPascalParser.ScalarTypeContext context)
        {
            VisitType(context, PascalNodeTypes.ScalarType);
            return null;
        }

        public override object VisitSet(GPascalParser.SetContext context)
        {
            VisitType(context, PascalNodeTypes.Set);
            return null;
        }

        public override object VisitSetType(GPascalParser.SetTypeContext context)
        {
            VisitType(context, PascalNodeTypes.SetType);
            return null;
        }

        public override object VisitSign(GPascalParser.SignContext context)
        {
            VisitType(context, PascalNodeTypes.Sign);
            return null;
        }

        public override object VisitSignedFactor(GPascalParser.SignedFactorContext context)
        {
            VisitType(context, PascalNodeTypes.SignedFactor);
            return null;
        }

        public override object VisitSimpleExpression(GPascalParser.SimpleExpressionContext context)
        {
            VisitType(context, PascalNodeTypes.SimpleExpression);
            return null;
        }

        public override object VisitSimpleStatement(GPascalParser.SimpleStatementContext context)
        {
            VisitType(context, PascalNodeTypes.SimpleStatement);
            return null;
        }

        public override object VisitSimpleType(GPascalParser.SimpleTypeContext context)
        {
            VisitType(context, PascalNodeTypes.SimpleType);
            return null;
        }

        public override object VisitStatement(GPascalParser.StatementContext context)
        {
            VisitType(context, PascalNodeTypes.Statement);
            return null;
        }

        public override object VisitStatements(GPascalParser.StatementsContext context)
        {
            VisitType(context, PascalNodeTypes.Statements);
            return null;
        }

        public override object VisitString(GPascalParser.StringContext context)
        {
            VisitType(context, PascalNodeTypes.String);
            return null;
        }

        public override object VisitStringtype(GPascalParser.StringtypeContext context)
        {
            VisitType(context, PascalNodeTypes.Stringtype);
            return null;
        }

        public override object VisitStructuredStatement(GPascalParser.StructuredStatementContext context)
        {
            VisitType(context, PascalNodeTypes.StructuredStatement);
            return null;
        }

        public override object VisitStructuredType(GPascalParser.StructuredTypeContext context)
        {
            VisitType(context, PascalNodeTypes.StructuredType);
            return null;
        }

        public override object VisitSubrangeType(GPascalParser.SubrangeTypeContext context)
        {
            VisitType(context, PascalNodeTypes.SubrangeType);
            return null;
        }

        public override object VisitTag(GPascalParser.TagContext context)
        {
            VisitType(context, PascalNodeTypes.Tag);
            return null;
        }

        public override object VisitTerm(GPascalParser.TermContext context)
        {
            VisitType(context, PascalNodeTypes.Term);
            return null;
        }

        public override object VisitType(GPascalParser.TypeContext context)
        {
            VisitType(context, PascalNodeTypes.Type);
            return null;
        }

        public override object VisitTypeDefinition(GPascalParser.TypeDefinitionContext context)
        {
            VisitType(context, PascalNodeTypes.TypeDefinition);
            return null;
        }

        public override object VisitTypeDefinitionPart(GPascalParser.TypeDefinitionPartContext context)
        {
            VisitType(context, PascalNodeTypes.TypeDefinitionPart);
            return null;
        }

        public override object VisitTypeIdentifier(GPascalParser.TypeIdentifierContext context)
        {
            VisitType(context, PascalNodeTypes.TypeIdentifier);
            return null;
        }

        public override object VisitTypeList(GPascalParser.TypeListContext context)
        {
            VisitType(context, PascalNodeTypes.TypeList);
            return null;
        }

        public override object VisitUnlabelledStatement(GPascalParser.UnlabelledStatementContext context)
        {
            VisitType(context, PascalNodeTypes.UnlabelledStatement);
            return null;
        }

        public override object VisitUnpackedStructuredType(GPascalParser.UnpackedStructuredTypeContext context)
        {
            VisitType(context, PascalNodeTypes.UnpackedStructuredType);
            return null;
        }

        public override object VisitUnsignedConstant(GPascalParser.UnsignedConstantContext context)
        {
            VisitType(context, PascalNodeTypes.UnsignedConstant);
            return null;
        }

        public override object VisitUnsignedInteger(GPascalParser.UnsignedIntegerContext context)
        {
            VisitType(context, PascalNodeTypes.UnsignedInteger);
            return null;
        }

        public override object VisitUnsignedNumber(GPascalParser.UnsignedNumberContext context)
        {
            VisitType(context, PascalNodeTypes.UnsignedNumber);
            return null;
        }

        public override object VisitUnsignedReal(GPascalParser.UnsignedRealContext context)
        {
            VisitType(context, PascalNodeTypes.UnsignedReal);
            return null;
        }

        public override object VisitUsesUnitsPart(GPascalParser.UsesUnitsPartContext context)
        {
            VisitType(context, PascalNodeTypes.UsesUnitsPart);
            return null;
        }

        public override object VisitVariable(GPascalParser.VariableContext context)
        {
            VisitType(context, PascalNodeTypes.Variable);
            return null;
        }

        public override object VisitVariableDeclaration(GPascalParser.VariableDeclarationContext context)
        {
            VisitType(context, PascalNodeTypes.VariableDeclaration);
            return null;
        }

        public override object VisitVariableDeclarationPart(GPascalParser.VariableDeclarationPartContext context)
        {
            VisitType(context, PascalNodeTypes.VariableDeclarationPart);
            return null;
        }

        public override object VisitVariant(GPascalParser.VariantContext context)
        {
            VisitType(context, PascalNodeTypes.Variant);
            return null;
        }

        public override object VisitVariantPart(GPascalParser.VariantPartContext context)
        {
            VisitType(context, PascalNodeTypes.VariantPart);
            return null;
        }

        public override object VisitWhileStatement(GPascalParser.WhileStatementContext context)
        {
            VisitType(context, PascalNodeTypes.WhileStatement);
            return null;
        }

        public override object VisitWithStatement(GPascalParser.WithStatementContext context)
        {
            VisitType(context, PascalNodeTypes.WithStatement);
            return null;
        }
    }
}