import React from 'react'
import SubmitInput from '../forms/SubmitInput'
import Error from '../common/Error'

export default class AddReviewForm extends React.Component {
  render () {
    let review = this.props.review
    return (
      <div className='row'>
        <div className='col-md-8 col-md-offset-3 text-left'>
          <form className='form-horizontal' onSubmit={this.props.onSubmit}>
            <ul className='review-rating'>
              <li><span>1</span><input type='radio' name='rating' value='1' onChange={this.props.onChange} /></li>
              <li><span>2</span><input type='radio' name='rating' value='2' onChange={this.props.onChange} /> </li>
              <li><span>3</span><input type='radio' name='rating' value='3' onChange={this.props.onChange} /> </li>
              <li><span>4</span><input type='radio' name='rating' value='4' onChange={this.props.onChange} /></li>
              <li><span>5</span><input type='radio' name='rating' value='5' onChange={this.props.onChange} /></li>
            </ul>
            <div className='review-add-text'>
              <textarea
                cols='60'
                rows='4'
                name='text'
                placeholder='Text'
                value={review.text}
                onChange={this.props.onChange} />
            </div>
            <div className='review-add-btn'>
              <SubmitInput value='Add review' />
            </div>
            <Error error={this.props.error} />
          </form>
        </div>
      </div>
    )
  }
}
