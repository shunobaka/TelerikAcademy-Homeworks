var html = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';

var output = extractText(html);
console.log(output);

function extractText(html) {
    var ltindex,
        gtindex,
        subToRemove;

    for (;;) {
        ltindex = html.indexOf('<');
        if (ltindex !== -1) {
            gtindex = html.indexOf('>');
        } else {
            break;
        }

        subToRemove = html.substring(ltindex, gtindex + 1);
        html = html.replace(subToRemove, '');
    }

    return html;
}
