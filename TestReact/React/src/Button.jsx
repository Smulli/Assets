import PropTypes from 'prop-types'

function Button({text = "Default text"}) {
    if(!text){
        console.error("El texto es requerido")
    }

    return <button>
        {text}
    </button>
}

Button.propTypes = {
    text: PropTypes.string.isRequired
}

export default Button
