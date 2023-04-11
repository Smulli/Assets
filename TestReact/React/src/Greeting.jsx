export function Greeting() {

    const married = false

    //return <h1>{married ? 'Estoy casado' : 'No estoy casado 😃'}</h1>

    const user = {
        firstName: 'Ryan',
        lastName: 'Hamburguer'
    }

    function add(x, y){
        return x + y
    }

    return <>
        <h1>{user.firstName}</h1>
        <h2>{user.lastName}</h2>
        <h3>{married.toString()}</h3>
        <h4>{add(10, 30)}</h4>
    </>
}

export function Name() {
    const name = "Albert"

    return <h1>{name}</h1>
}

export function Salute(prop){
    console.log(prop)

    return <h1>Saludo, {prop.title} y también {prop.name}</h1>
}

export function AlternateSalute({title, name = "User"}){
    console.log({title, name})
}

export function UserCard(props){
    console.log(props)
    
    return (
        <div>
            <ul>
                <li>Name: {props.name}</li>
                <li>City: {props.adress.city}</li>
            </ul>
        </div>
    )
}

export function AlternateUserCard({name, adress = "none"}){   
    return (
        <div>
            <ul>
                <li>Name: {name}</li>
                <li>City: {adress.city}</li>
            </ul>
        </div>
    )
}