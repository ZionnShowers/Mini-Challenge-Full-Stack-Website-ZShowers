const url = "http://localhost:5108/api/"

const addForm = document.getElementById("add-form");
const inputOne = document.getElementById("number-one");
const inputTwo = document.getElementById("number-two");
const addOutput = document.getElementById("add-output");

const compForm = document.getElementById("comp-form");
const compOutput = document.getElementById("comp-output");

const nameForm = document.getElementById("name-form");
const nameOutput = document.getElementById("name-output");
const name = document.getElementById("name");

const magicForm = document.getElementById("magic-form");
const magicOutput = document.getElementById("magic-output");

const restForm = document.getElementById("rest-form");
const restOutput = document.getElementById("rest-output");

const madlibForm = document.getElementById("madlib-form");
const madlibOutput = document.getElementById("madlib-output");
const word1 = document.getElementById("word-1");
const word2 = document.getElementById("word-2");
const word3 = document.getElementById("word-3");
const word4 = document.getElementById("word-4");
const word5 = document.getElementById("word-5");
const word6 = document.getElementById("word-6");
const word7 = document.getElementById("word-7");
const word8 = document.getElementById("word-8");
const word9 = document.getElementById("word-9");
const word10 = document.getElementById("word-10");

//MINI 2: ADDING
const additionFetch = async (numberOne, numberTwo) => {
    const response = await fetch(`${url}adding/addition/${numberOne}/${numberTwo}`);
    const data = await response.json();
    console.log(data);
    return data;
}
if (addForm != null){ //Fix main page error

    addForm.addEventListener("submit", async (event)=> {
        event.preventDefault();//
    
        //
        const output = await additionFetch(inputOne.value, inputTwo.value);
    
        addOutput.textContent = `The sum of ${output.numOne} and ${output.numTwo} is ${output.result}!`;
    });
}

//MINI 3: COMPARING
const comparisonFetch = async (numberOne, numberTwo) => {
    const response = await fetch(`${url}comparing/comparison/${numberOne}/${numberTwo}`);
    const data = await response.json();
    console.log(data);
    return data;
}
if (compForm != null){ //Fix main page error

    compForm.addEventListener("submit", async (event)=> {
        event.preventDefault();//
    
        //
        const output = await comparisonFetch(inputOne.value, inputTwo.value);
    
        compOutput.textContent = `${output.message}!`;
    });
}

//MINI 1: Say Hello
const sayHelloFetch = async (name) => {
    const response = await fetch(`${url}hello/sayhello/${name}`);
    const data = await response.json();
    console.log(data);
    return data;
}
if (nameForm != null){ //Fix main page error

    nameForm.addEventListener("submit", async (event)=> {
        event.preventDefault();//
    
        //
        const output = await sayHelloFetch(name.value);
    
        nameOutput.textContent = `${output.message}`;
    });
}

//MINI 4: Magic 8 Ball
const magicBallFetch = async () => {
    const response = await fetch(`${url}magic/magicball`);
    const data = await response.json();
    console.log(data);
    return data;
}
if (magicForm != null){ //Fix main page error

    magicForm.addEventListener("submit", async (event)=> {
        event.preventDefault();//
    
        //
        const output = await magicBallFetch();
    
        magicOutput.textContent = `${output.message}`;
    });
}

//MINI 5: restaurant
const restaurantFetch = async (numberOne) => {
    const response = await fetch(`${url}food/restaurant/${numberOne}`);
    const data = await response.json();
    console.log(data);
    return data;
}
if (restForm != null){ //Fix main page error

    restForm.addEventListener("submit", async (event)=> {
        event.preventDefault();//
    
        //
        const output = await restaurantFetch(inputOne.value);
    
        restOutput.textContent = `${output.message}`;
    });
}

//MINI 6: MADLIB
const madlibFetch = async (word1,word2,word3,word4,word5,word6,word7,word8,word9,word10) => {
    const response = await fetch(`${url}madlib/madlib/${word1}/${word2}/${word3}/${word4}/${word5}/${word6}/${word7}/${word8}/${word9}/${word10}`);
    const data = await response.json();
    console.log(data);
    return data;
}
if (madlibForm != null){ //Fix main page error

    madlibForm.addEventListener("submit", async (event)=> {
        event.preventDefault();//
    
        //
        const output = await madlibFetch(word1.value, word2.value, word3.value, word4.value, word5.value, word6.value, word7.value, word8.value, word9.value, word10.value);
    
        madlibOutput.textContent = `${output.message}`;
    });
}