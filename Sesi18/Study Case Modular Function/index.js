console.clear()

function removeSpaces (text) {
    return text.split(" ").join("")
}

function reverseText (text) {
    return text.split("").reverse().join("");
}

function updateVowels (text) {
    let vowelsSubstitute = {
        A : "B",
        I : "J",
        U : "V",
        E : "F",
        O : "P",
        a : "b",
        i : "j",
        u : "v",
        e : "f",
        o : "p"
    }

    let array = text.split("")

    for (let i = 0 ; i < array.length ; i++) {
        let substitute = vowelsSubstitute[array[i]]
        if (substitute != undefined) {
            array[i] = substitute
        }
    }

    return array.join("")
}

var password = 'Abcd ef'

var noSpaces = removeSpaces(password)
console.log(noSpaces);

var reversed = reverseText(noSpaces)
console.log(reversed);

var encryptedPassword = updateVowels(reversed)
console.log(encryptedPassword);