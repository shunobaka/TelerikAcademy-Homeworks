function generateList() {
    var index,
        result = '<ul>',
        currentItem,
        prop,
        forReplacement,
        template = document.getElementById('list-item').innerHTML;

    var people = [{
        name: 'Pesho',
        age: 25
    }, {
        name: 'Gosho',
        age: 54
    }, {
        name: 'Ivo',
        age: 32
    }, {
        name: 'Niki',
        age: 12
    }, {
        name: 'Joro',
        age: 65
    }, {
        name: 'Hristo',
        age: 43
    }, {
        name: 'Alex',
        age: 34
    }, {
        name: 'Lozan',
        age: 21
    }];

    for (index in people) {
        currentItem = '<li>' + template;
        currentPerson = people[index];
        for (prop in currentPerson) {
            forReplacement = '-{' + prop + '}-';
            currentItem = currentItem.replace(forReplacement, currentPerson[prop]);
        }
        result += currentItem + '</li>';
    }
    document.getElementById('list-item').innerHTML = result + '</ul>';
}
