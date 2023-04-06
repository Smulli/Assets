import React from 'react'
import ReactDOM from 'react-dom/client'
import { AlternateSalute, Greeting, Name, Salute, UserCard, AlternateUserCard } from './Greeting'
import Product, { Navbar } from './Product'
import Button from './Button'
import TaskCard from './Task'

const root = ReactDOM.createRoot(document.getElementById('root'))

root.render(<>

    <Button text="Check Out"/>
    <TaskCard ready={false}/>
    {/*<Greeting />
    <Name />
    <Product />
    <Salute title="hola" name="Joe" />
    <Salute title="hola Albert" />
    <Salute x="bye" />
    <Salute y={30} />
    <Salute z={true} />
    <Salute a={[0, 1, 2, 3]} />
    <AlternateSalute title={"Hola React"} name={"Ryan"} />
    <AlternateSalute title={"Hola React"} />
    <UserCard name="Ryan" 
        amount={3000} 
        married={true} 
        points={[99, 0.333]} 
        adress={{ street: '1234 Calle Simpson', city: 'Madrid' }}
        greet={function() {alert("Hello")}}  
    />
    <AlternateUserCard name="Ryan" 
        amount={3000} 
        married={true} 
        points={[99, 0.333]} 
        adress={{ 
            street: '1234 Calle Simpson', 
            city: 'Madrid' 
            }}
    />*/}
</>)