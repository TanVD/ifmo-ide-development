using JetBrains.Diagnostics;
using JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Gen;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace JetBrains.ReSharper.Plugins.Spring.Parser.Psi.Node
{
    public static class PascalAntlrNodeTypesFactoryGen
    {
        public static CompositeElement Create(PascalAntlrNodeType type, object data)
        {
            if (type == PascalNodeTypes.ActualParameter)
            {
                return new PascalActualParameter((GPascalParser.ActualParameterContext) data);
            }

            if (type == PascalNodeTypes.Additiveoperator)
            {
                return new PascalAdditiveoperator((GPascalParser.AdditiveoperatorContext) data);
            }

            if (type == PascalNodeTypes.ArrayType)
            {
                return new PascalArrayType((GPascalParser.ArrayTypeContext) data);
            }

            if (type == PascalNodeTypes.AssignmentStatement)
            {
                return new PascalAssignmentStatement((GPascalParser.AssignmentStatementContext) data);
            }

            if (type == PascalNodeTypes.BaseType)
            {
                return new PascalBaseType((GPascalParser.BaseTypeContext) data);
            }

            if (type == PascalNodeTypes.Block)
            {
                return new PascalBlock((GPascalParser.BlockContext) data);
            }

            if (type == PascalNodeTypes.Bool)
            {
                return new PascalBool((GPascalParser.BoolContext) data);
            }

            if (type == PascalNodeTypes.CaseListElement)
            {
                return new PascalCaseListElement((GPascalParser.CaseListElementContext) data);
            }

            if (type == PascalNodeTypes.CaseStatement)
            {
                return new PascalCaseStatement((GPascalParser.CaseStatementContext) data);
            }

            if (type == PascalNodeTypes.ComponentType)
            {
                return new PascalComponentType((GPascalParser.ComponentTypeContext) data);
            }

            if (type == PascalNodeTypes.CompoundStatement)
            {
                return new PascalCompoundStatement((GPascalParser.CompoundStatementContext) data);
            }

            if (type == PascalNodeTypes.ConditionalStatement)
            {
                return new PascalConditionalStatement((GPascalParser.ConditionalStatementContext) data);
            }

            if (type == PascalNodeTypes.ConstList)
            {
                return new PascalConstList((GPascalParser.ConstListContext) data);
            }

            if (type == PascalNodeTypes.Constant)
            {
                return new PascalConstant((GPascalParser.ConstantContext) data);
            }

            if (type == PascalNodeTypes.ConstantChr)
            {
                return new PascalConstantChr((GPascalParser.ConstantChrContext) data);
            }

            if (type == PascalNodeTypes.ConstantDefinition)
            {
                return new PascalConstantDefinition((GPascalParser.ConstantDefinitionContext) data);
            }

            if (type == PascalNodeTypes.ConstantDefinitionPart)
            {
                return new PascalConstantDefinitionPart((GPascalParser.ConstantDefinitionPartContext) data);
            }

            if (type == PascalNodeTypes.Element)
            {
                return new PascalElement((GPascalParser.ElementContext) data);
            }

            if (type == PascalNodeTypes.ElementList)
            {
                return new PascalElementList((GPascalParser.ElementListContext) data);
            }

            if (type == PascalNodeTypes.Empty)
            {
                return new PascalEmpty((GPascalParser.EmptyContext) data);
            }

            if (type == PascalNodeTypes.EmptyStatement)
            {
                return new PascalEmptyStatement((GPascalParser.EmptyStatementContext) data);
            }

            if (type == PascalNodeTypes.Expression)
            {
                return new PascalExpression((GPascalParser.ExpressionContext) data);
            }

            if (type == PascalNodeTypes.Factor)
            {
                return new PascalFactor((GPascalParser.FactorContext) data);
            }

            if (type == PascalNodeTypes.FieldList)
            {
                return new PascalFieldList((GPascalParser.FieldListContext) data);
            }

            if (type == PascalNodeTypes.FileType)
            {
                return new PascalFileType((GPascalParser.FileTypeContext) data);
            }

            if (type == PascalNodeTypes.FinalValue)
            {
                return new PascalFinalValue((GPascalParser.FinalValueContext) data);
            }

            if (type == PascalNodeTypes.FixedPart)
            {
                return new PascalFixedPart((GPascalParser.FixedPartContext) data);
            }

            if (type == PascalNodeTypes.ForList)
            {
                return new PascalForList((GPascalParser.ForListContext) data);
            }

            if (type == PascalNodeTypes.ForStatement)
            {
                return new PascalForStatement((GPascalParser.ForStatementContext) data);
            }

            if (type == PascalNodeTypes.FormalParameterList)
            {
                return new PascalFormalParameterList((GPascalParser.FormalParameterListContext) data);
            }

            if (type == PascalNodeTypes.FormalParameterSection)
            {
                return new PascalFormalParameterSection((GPascalParser.FormalParameterSectionContext) data);
            }

            if (type == PascalNodeTypes.FunctionDeclaration)
            {
                return new PascalFunctionDeclaration((GPascalParser.FunctionDeclarationContext) data);
            }

            if (type == PascalNodeTypes.FunctionDesignator)
            {
                return new PascalFunctionDesignator((GPascalParser.FunctionDesignatorContext) data);
            }

            if (type == PascalNodeTypes.FunctionType)
            {
                return new PascalFunctionType((GPascalParser.FunctionTypeContext) data);
            }

            if (type == PascalNodeTypes.GotoStatement)
            {
                return new PascalGotoStatement((GPascalParser.GotoStatementContext) data);
            }

            if (type == PascalNodeTypes.Identifier)
            {
                return new PascalIdentifier((GPascalParser.IdentifierContext) data);
            }

            if (type == PascalNodeTypes.IdentifierList)
            {
                return new PascalIdentifierList((GPascalParser.IdentifierListContext) data);
            }

            if (type == PascalNodeTypes.IfStatement)
            {
                return new PascalIfStatement((GPascalParser.IfStatementContext) data);
            }

            if (type == PascalNodeTypes.IndexType)
            {
                return new PascalIndexType((GPascalParser.IndexTypeContext) data);
            }

            if (type == PascalNodeTypes.InitialValue)
            {
                return new PascalInitialValue((GPascalParser.InitialValueContext) data);
            }

            if (type == PascalNodeTypes.Label)
            {
                return new PascalLabel((GPascalParser.LabelContext) data);
            }

            if (type == PascalNodeTypes.LabelDeclarationPart)
            {
                return new PascalLabelDeclarationPart((GPascalParser.LabelDeclarationPartContext) data);
            }

            if (type == PascalNodeTypes.Multiplicativeoperator)
            {
                return new PascalMultiplicativeoperator((GPascalParser.MultiplicativeoperatorContext) data);
            }

            if (type == PascalNodeTypes.ParameterGroup)
            {
                return new PascalParameterGroup((GPascalParser.ParameterGroupContext) data);
            }

            if (type == PascalNodeTypes.ParameterList)
            {
                return new PascalParameterList((GPascalParser.ParameterListContext) data);
            }

            if (type == PascalNodeTypes.Parameterwidth)
            {
                return new PascalParameterwidth((GPascalParser.ParameterwidthContext) data);
            }

            if (type == PascalNodeTypes.PointerType)
            {
                return new PascalPointerType((GPascalParser.PointerTypeContext) data);
            }

            if (type == PascalNodeTypes.ProcedureAndFunctionDeclarationPart)
            {
                return new PascalProcedureAndFunctionDeclarationPart((GPascalParser.ProcedureAndFunctionDeclarationPartContext) data);
            }

            if (type == PascalNodeTypes.ProcedureDeclaration)
            {
                return new PascalProcedureDeclaration((GPascalParser.ProcedureDeclarationContext) data);
            }

            if (type == PascalNodeTypes.ProcedureOrFunctionDeclaration)
            {
                return new PascalProcedureOrFunctionDeclaration((GPascalParser.ProcedureOrFunctionDeclarationContext) data);
            }

            if (type == PascalNodeTypes.ProcedureStatement)
            {
                return new PascalProcedureStatement((GPascalParser.ProcedureStatementContext) data);
            }

            if (type == PascalNodeTypes.ProcedureType)
            {
                return new PascalProcedureType((GPascalParser.ProcedureTypeContext) data);
            }

            if (type == PascalNodeTypes.Program)
            {
                return new PascalProgram((GPascalParser.ProgramContext) data);
            }

            if (type == PascalNodeTypes.ProgramHeading)
            {
                return new PascalProgramHeading((GPascalParser.ProgramHeadingContext) data);
            }

            if (type == PascalNodeTypes.RecordSection)
            {
                return new PascalRecordSection((GPascalParser.RecordSectionContext) data);
            }

            if (type == PascalNodeTypes.RecordType)
            {
                return new PascalRecordType((GPascalParser.RecordTypeContext) data);
            }

            if (type == PascalNodeTypes.RecordVariableList)
            {
                return new PascalRecordVariableList((GPascalParser.RecordVariableListContext) data);
            }

            if (type == PascalNodeTypes.Relationaloperator)
            {
                return new PascalRelationaloperator((GPascalParser.RelationaloperatorContext) data);
            }

            if (type == PascalNodeTypes.RepeatStatement)
            {
                return new PascalRepeatStatement((GPascalParser.RepeatStatementContext) data);
            }

            if (type == PascalNodeTypes.RepetetiveStatement)
            {
                return new PascalRepetetiveStatement((GPascalParser.RepetetiveStatementContext) data);
            }

            if (type == PascalNodeTypes.ResultType)
            {
                return new PascalResultType((GPascalParser.ResultTypeContext) data);
            }

            if (type == PascalNodeTypes.ScalarType)
            {
                return new PascalScalarType((GPascalParser.ScalarTypeContext) data);
            }

            if (type == PascalNodeTypes.Set)
            {
                return new PascalSet((GPascalParser.SetContext) data);
            }

            if (type == PascalNodeTypes.SetType)
            {
                return new PascalSetType((GPascalParser.SetTypeContext) data);
            }

            if (type == PascalNodeTypes.Sign)
            {
                return new PascalSign((GPascalParser.SignContext) data);
            }

            if (type == PascalNodeTypes.SignedFactor)
            {
                return new PascalSignedFactor((GPascalParser.SignedFactorContext) data);
            }

            if (type == PascalNodeTypes.SimpleExpression)
            {
                return new PascalSimpleExpression((GPascalParser.SimpleExpressionContext) data);
            }

            if (type == PascalNodeTypes.SimpleStatement)
            {
                return new PascalSimpleStatement((GPascalParser.SimpleStatementContext) data);
            }

            if (type == PascalNodeTypes.SimpleType)
            {
                return new PascalSimpleType((GPascalParser.SimpleTypeContext) data);
            }

            if (type == PascalNodeTypes.Statement)
            {
                return new PascalStatement((GPascalParser.StatementContext) data);
            }

            if (type == PascalNodeTypes.Statements)
            {
                return new PascalStatements((GPascalParser.StatementsContext) data);
            }

            if (type == PascalNodeTypes.String)
            {
                return new PascalString((GPascalParser.StringContext) data);
            }

            if (type == PascalNodeTypes.Stringtype)
            {
                return new PascalStringtype((GPascalParser.StringtypeContext) data);
            }

            if (type == PascalNodeTypes.StructuredStatement)
            {
                return new PascalStructuredStatement((GPascalParser.StructuredStatementContext) data);
            }

            if (type == PascalNodeTypes.StructuredType)
            {
                return new PascalStructuredType((GPascalParser.StructuredTypeContext) data);
            }

            if (type == PascalNodeTypes.SubrangeType)
            {
                return new PascalSubrangeType((GPascalParser.SubrangeTypeContext) data);
            }

            if (type == PascalNodeTypes.Tag)
            {
                return new PascalTag((GPascalParser.TagContext) data);
            }

            if (type == PascalNodeTypes.Term)
            {
                return new PascalTerm((GPascalParser.TermContext) data);
            }

            if (type == PascalNodeTypes.Type)
            {
                return new PascalType((GPascalParser.TypeContext) data);
            }

            if (type == PascalNodeTypes.TypeDefinition)
            {
                return new PascalTypeDefinition((GPascalParser.TypeDefinitionContext) data);
            }

            if (type == PascalNodeTypes.TypeDefinitionPart)
            {
                return new PascalTypeDefinitionPart((GPascalParser.TypeDefinitionPartContext) data);
            }

            if (type == PascalNodeTypes.TypeIdentifier)
            {
                return new PascalTypeIdentifier((GPascalParser.TypeIdentifierContext) data);
            }

            if (type == PascalNodeTypes.TypeList)
            {
                return new PascalTypeList((GPascalParser.TypeListContext) data);
            }

            if (type == PascalNodeTypes.UnlabelledStatement)
            {
                return new PascalUnlabelledStatement((GPascalParser.UnlabelledStatementContext) data);
            }

            if (type == PascalNodeTypes.UnpackedStructuredType)
            {
                return new PascalUnpackedStructuredType((GPascalParser.UnpackedStructuredTypeContext) data);
            }

            if (type == PascalNodeTypes.UnsignedConstant)
            {
                return new PascalUnsignedConstant((GPascalParser.UnsignedConstantContext) data);
            }

            if (type == PascalNodeTypes.UnsignedInteger)
            {
                return new PascalUnsignedInteger((GPascalParser.UnsignedIntegerContext) data);
            }

            if (type == PascalNodeTypes.UnsignedNumber)
            {
                return new PascalUnsignedNumber((GPascalParser.UnsignedNumberContext) data);
            }

            if (type == PascalNodeTypes.UnsignedReal)
            {
                return new PascalUnsignedReal((GPascalParser.UnsignedRealContext) data);
            }

            if (type == PascalNodeTypes.UsesUnitsPart)
            {
                return new PascalUsesUnitsPart((GPascalParser.UsesUnitsPartContext) data);
            }

            if (type == PascalNodeTypes.Variable)
            {
                return new PascalVariable((GPascalParser.VariableContext) data);
            }

            if (type == PascalNodeTypes.VariableDeclaration)
            {
                return new PascalVariableDeclaration((GPascalParser.VariableDeclarationContext) data);
            }

            if (type == PascalNodeTypes.VariableDeclarationPart)
            {
                return new PascalVariableDeclarationPart((GPascalParser.VariableDeclarationPartContext) data);
            }

            if (type == PascalNodeTypes.Variant)
            {
                return new PascalVariant((GPascalParser.VariantContext) data);
            }

            if (type == PascalNodeTypes.VariantPart)
            {
                return new PascalVariantPart((GPascalParser.VariantPartContext) data);
            }

            if (type == PascalNodeTypes.WhileStatement)
            {
                return new PascalWhileStatement((GPascalParser.WhileStatementContext) data);
            }

            if (type == PascalNodeTypes.WithStatement)
            {
                return new PascalWithStatement((GPascalParser.WithStatementContext) data);
            }

            Assertion.Fail($"PascalAntlrNodeType with non-defined Create {type}");
            return null;
        }
    }
}