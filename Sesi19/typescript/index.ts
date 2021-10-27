// const hello: string = "Hello World"

// function getHello (message:string)  {
//     return message;
// }

// console.log(getHello(`Hello ${hello}! Nice to meet you`))

interface Person {
    name: string,
    age?: number
}

let arrayPerson: Person[] = [
    {
        name: "Yosafat",
        age: 21
    },
    {
        name: "Test"
    }
]

arrayPerson.push({
    name: "Baba",
    age: 23
})

console.log(arrayPerson)