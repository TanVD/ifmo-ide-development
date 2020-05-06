package com.jetbrains.rider.ideaInterop.fileTypes.pascal

import com.jetbrains.rider.ideaInterop.fileTypes.RiderLanguageBase

object PascalLanguage : RiderLanguageBase("Pascal", "Pascal") {
    override fun isCaseSensitive(): Boolean = false

}
