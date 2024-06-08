import React, { useState } from "react"
import PropTypes from "prop-types";

export default function Card({ image, gif, title, content, urlText, hRef, tag }) {
    const [isHovered, setIsHovered] = useState(false);

    const handleMouseEnter = () => {
        setIsHovered(true);
    };

    const handleMouseLeave = () => {
        setIsHovered(false);
    };

    return <div className="card text-center rounded-0 shadow bg-gradient-dark" onMouseEnter={handleMouseEnter} onMouseLeave={handleMouseLeave}>
        <picture>
            <img src={isHovered ? gif : image} alt="Poplloon Project" width={355} height={200} />
        </picture>
        <div className="card-body">
            <h4 className="card-title">{title}</h4>
            <p className="card-text text-secundary">{content}</p>
            <a href={hRef} className="btn btn-outline-secondary rounded-0" target="_blank" rel="noopener noreferrer">{urlText}</a>
            <blockquote className="mt-2 text-muted"><small>{tag}</small></blockquote>
        </div>
    </div>
}

Card.propTypes = {
    image: PropTypes.string,
    gif: PropTypes.string,
    title: PropTypes.string,
    content: PropTypes.string,
    urlText: PropTypes.string,
    tag: PropTypes.string
}