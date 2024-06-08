import Card from "../components/Card";

export default function RowCardContent({ title, contentData }) {
    return <div className="container d-flex justify-content-center align-items-center h-100 mt-5">
        <div className="row">
            <h1 className="mb-5 pt-5">- {title} -</h1>
            {
                contentData.map(contentSet => (
                    <div className="col-md-4" key={contentSet.id}>
                        <Card image={contentSet.staticImage} gif={contentSet.gifImage} title={contentSet.title} content={contentSet.content} urlText={contentSet.btnText} hRef={contentSet.url} tag={contentSet.tag} />
                    </div>
                ))
            }
        </div>
    </div>
}