[Your pull request description here]

## Related / Dependant PRs?

<!--- List any related issues here -->

## How Has This Been Tested?

<!--- Please describe how you tested your changes -->

## Peer Reviews Checklist
#### Below is a list of items that commonly appear in pull requests and possible resolutions/key places to lookout for.
<!--- Go over all the following points, and put an `x` in all the boxes that apply. -->
<!--- If you're unsure about any of these, don't hesitate to ask. We're here to help! -->

- [ ] Breaking change (fix or feature that would cause existing functionality to change).
- [ ] Build passing.
- [ ] Unit tests have full coverage.
- [ ] Unit test approach and implementation has been reviewed with QA (testers).
- [ ] Hard coded values/strings – let’s place in a common library i.e. the api-config package or api-enums package.
- [ ] Appropriate labels added.
- [ ] Empty snapshot tests - remove snapshots that are catching empty objects.
- [ ] Testing date or times – use MockDate to set the JavaScript global date for test.

- [ ] Unnecessary items in IAM roles – specifically the join condition and the allowed access on the role itself.

- [ ] Spelling and grammar – mainly arises in variable names or test descriptions i.e. describe() and it().

- [ ] Leaving behind .gitignore – Remove any .gitignore files after adding implementation.

- [ ] Doc readme layout – Sections may look different in VS Code to how they do when rendered in the GitHub preview.

- [ ] Utilise current Shared functions – check if you’re doing something that has already been done *common example are result vtls.

- [ ] Implement new Shared functions – if there’s a special requirement to your pipeline can/will it be used by any other endpoint, if so, make it shared.

- [ ] Missing test files or tests – Completely missing spec files or missing valid test cases to ensure the behavior has been caught.

- [ ] Function naming conventions – Ensure that function names correctly indicate what they are doing so they can be easily understood by someone else looking at the code.

- [ ] Duplicating docs - Enums or other types that are used in multiple places are often duplicated due to their location. Ensure they are not defined elsewhere and if they are move to a common location i.e. top of the docs in a new section.

- [ ] Files and folder conventions - hyphenated folders and camel case function names i.e. get-payslip/Function.getPayslip.req.vtl.

- [ ] Substitutions global and uk implementation – use the relevant locale in test file substitutions. i.e. p60s use uk, or Payslip uk functionality use uk not global.

- [ ] Typescript ensure types are set – any changes to the typescript packages require types to be defined. *Run build after changes that will identify any ES Lint issues.

- [ ] Additional line at the End of the File – Check for the extra line at the EOF. Turn on VS Code additional EOF line setting for this to automatically happen.
