package com.jetbrains.rider.ideaInterop.fileTypes.pascal

import com.intellij.openapi.fileTypes.LanguageFileType

object PascalFileType : LanguageFileType(PascalLanguage) {
    override fun getName() = "Pascal"
    override fun getDefaultExtension() = "pas"
    override fun getDescription() = "Pascal file"
    override fun getIcon() = PascalIcons.MY_FILE_ICON
}
