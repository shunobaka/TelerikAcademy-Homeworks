var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";

var result = parseTags(text);

console.log(result);

function parseTags(text) {
    var endTagIndex,
        elementToReplace,
        elementContent,
        counterIndex,
        contentLen,
        resultContent = '',
        openTagIndex = 0;

    while (openTagIndex !== -1) {
        openTagIndex = text.indexOf('<mixcase>', openTagIndex);
        if (openTagIndex !== -1) {
            endTagIndex = text.indexOf('</mixcase>');
            elementToReplace = text.substring(openTagIndex, endTagIndex + 10);
            elementContent = text.substring(openTagIndex + 9, endTagIndex);
            for (counterIndex = 0, contentLen = elementContent.length; counterIndex < contentLen; counterIndex += 1) {
                var caseDecider = Math.random();
                if ((caseDecider * 10 | 0) >= 5) {
                    resultContent += elementContent[counterIndex].toUpperCase();
                } else {
                    resultContent += elementContent[counterIndex].toLowerCase();
                }
            }
            text = text.replace(elementToReplace, resultContent);
            resultContent = '';
            openTagIndex += 1;
        }
    }

    openTagIndex = 0;

    while (openTagIndex !== -1) {
        openTagIndex = text.indexOf('<upcase>', openTagIndex);
        if (openTagIndex !== -1) {
            endTagIndex = text.indexOf('</upcase>');
            elementToReplace = text.substring(openTagIndex, endTagIndex + 9);
            elementContent = text.substring(openTagIndex + 8, endTagIndex);
            resultContent = elementContent.toUpperCase();
            text = text.replace(elementToReplace, resultContent);
        }
    }

    openTagIndex = 0;

    while (openTagIndex !== -1) {
        openTagIndex = text.indexOf('<lowcase>', openTagIndex);
        if (openTagIndex !== -1) {
            endTagIndex = text.indexOf('</lowcase>');
            elementToReplace = text.substring(openTagIndex, endTagIndex + 10);
            elementContent = text.substring(openTagIndex + 9, endTagIndex);
            resultContent = elementContent.toLowerCase();
            text = text.replace(elementToReplace, resultContent);
        }
    }

    return text;
}
