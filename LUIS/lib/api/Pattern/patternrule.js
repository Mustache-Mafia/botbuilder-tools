const {ServiceBase} = require('../serviceBase');
class Patternrule extends ServiceBase {
    constructor() {
        super('/apps/{appId}/versions/{versionId}/patternrule');
    }

    /**
    * undefined
    */
    AddPattern(params , pattern/* PatternRuleCreateObject */) {
        return this.createRequest('', params, 'post', pattern);
    }
}
module.exports = Patternrule;
