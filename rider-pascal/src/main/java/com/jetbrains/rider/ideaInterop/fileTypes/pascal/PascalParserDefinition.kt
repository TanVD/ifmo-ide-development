package com.jetbrains.rider.ideaInterop.fileTypes.pascal

import com.intellij.lexer.Lexer
import com.intellij.openapi.project.Project
import com.intellij.psi.tree.IElementType
import com.intellij.psi.tree.IFileElementType
import com.jetbrains.rider.ideaInterop.fileTypes.RiderDummyLexer
import com.jetbrains.rider.ideaInterop.fileTypes.RiderFileElementType
import com.jetbrains.rider.ideaInterop.fileTypes.RiderParserDefinitionBase

class PascalParserDefinition : RiderParserDefinitionBase(PascalFileElementType, PascalFileType) {
    companion object {
        val PascalElementType = IElementType("RIDER_PASCAL", PascalLanguage)
        val PascalFileElementType = RiderFileElementType("RIDER_PASCAL_FILE", PascalLanguage, PascalElementType)
    }

    override fun createLexer(project: Project?): Lexer = RiderDummyLexer(PascalLanguage)
    override fun getFileNodeType(): IFileElementType = PascalFileElementType
}
